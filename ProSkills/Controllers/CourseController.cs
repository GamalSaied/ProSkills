using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProSkills.Interfaces;
using ProSkills.Models.AdminPanel.InstructorManger;
using ProSkills.Models.ClientSide;
using ProSkills.Repositories;
using ProSkills.Repository;
using ProSkills.ViewModels;
using System.Collections.Generic;
using System.Drawing;

namespace ProSkills.Controllers
{
    public class CourseController : Controller
    {
        #region Repository 
        private IRepository<Course> _courseRepository;
        private IRepository<instructor> _instructorRepository;
        private IRepository<Trainee> _traineeRepository;
        private IRepository<CourseTrainee> _courseTraineeRepository;

        private IRepository<Category> _categoryRepository;
        private IRepository<RedeemCode> _redeemCodeRepository;
        private IRepository<Package> _packageRepository;
        private IRepository<Chapter> _chapterRepository;

        private ICourseRepository _courseRepositoryVersion2;

        private readonly IRepository<Lesson> _lessonRepository;

        private readonly ITIContext _context;

        public CourseController(IRepository<Trainee> traineeRepository, IRepository<CourseTrainee> courseTraineeRepository,IRepository<Lesson> lessonRepository,IRepository<Chapter> chapterRepository, IRepository<Course> CourseRepository, IRepository<instructor> InstructorRepository, IRepository<Category> CategoryRepository, IRepository<RedeemCode> RedeemCodeRepository, IRepository<Package> PackageRepository , ICourseRepository courseRepositoryVersion2)
        {
            _courseRepository = CourseRepository;
            _instructorRepository = InstructorRepository;
            _categoryRepository = CategoryRepository;
            _redeemCodeRepository = RedeemCodeRepository;
            _packageRepository = PackageRepository;
            _chapterRepository = chapterRepository;
            _lessonRepository = lessonRepository;
            _courseRepositoryVersion2 = courseRepositoryVersion2;
            _courseTraineeRepository = courseTraineeRepository;
            _traineeRepository = traineeRepository;


        }
        #endregion

        [HttpPost]
        public IActionResult UnassignTrainee(int courseId, int traineeId)
        {
            var courseTrainee = _courseTraineeRepository.GetAll()
                .FirstOrDefault(ct => ct.CourseId == courseId && ct.TraineeId == traineeId);

            if (courseTrainee != null)
            {
                _courseTraineeRepository.Delete(courseTrainee.Id);
                _courseTraineeRepository.Save();
            }

            return RedirectToAction("TraineesInCourse", new { courseId });
        }


        // GET: Course/AssignTrainee
        [HttpGet]
        public IActionResult AssignTrainee(int courseId)
        {
            var course = _courseRepository.GetById(courseId);
            if (course == null)
            {
                return NotFound();
            }

            ViewBag.CourseName = course.Name;
            ViewBag.CourseId = courseId;
            return View(new CourseTraineeViewModel { CourseId = courseId });
        }

        // POST: Course/AssignTrainee
        [HttpPost]
        public IActionResult AssignTrainee(CourseTraineeViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(model.Email))
                {
                    ModelState.AddModelError("", "Email is required.");
                    return View(model);
                }

                var trainee = _traineeRepository.GetAll()?.FirstOrDefault(t => t.Email == model.Email && !t.IsDeleted);
                if (trainee == null)
                {
                    ModelState.AddModelError("", "Trainee with the given email does not exist or is deleted.");
                }
                else
                {
                    var courseTrainee = new CourseTrainee
                    {
                        CourseId = model.CourseId,
                        TraineeId = trainee.Id
                    };

                    _courseTraineeRepository.Insert(courseTrainee);
                    _courseTraineeRepository.Save();

                    return RedirectToAction("TraineesInCourse", new { courseId = model.CourseId });
                }
            }

            var course = _courseRepository.GetById(model.CourseId);
            ViewBag.CourseName = course?.Name;
            return View(model);
        }


        public IActionResult TraineesInCourse(int courseId)
        {
            var course = _courseRepository.GetById(courseId);
            if (course == null)
            {
                return NotFound();
            }

            var trainees = course.Trainees.Select(ct => ct.Trainee).ToList();
            ViewBag.CourseName = course.Name;
            ViewBag.CourseId = courseId;
            return View(trainees);
        }

        public IActionResult Index1()
        {
            var courses = _courseRepository.GetAll();
            return View(courses);
        }

        //Filter By Instractor id
        public IActionResult Index(int id)
        {
            var courses = _courseRepository.GetAll();
            var instructorCourses = courses.Where(x => x.instructorId == id).ToList();
            ViewBag.InstructorID = id;
            return View("Index", instructorCourses);
        }

        public IActionResult New(int instructorId)  // Get Instructor ID From Course Page as Hidden
        {

            // Send Combobox Data to View
            List<Category> categoryData = _categoryRepository.GetAll().ToList();
            List<SelectListItem> categoryNames = categoryData
                .Select(c => new SelectListItem { Text = c.Name, Value = c.Name })
                .ToList();

            // Send Data To View
            ViewBag.CategoryNames = categoryNames;
            ViewBag.InstructorID = instructorId;                             // Send_Instructor ID
            return View("New");

        }

        public IActionResult SaveNew(Course CourseFromReq, int instructorId)  // Get_InstructorID from Hidden
        {




            string redeemCodeFromReq = CourseFromReq.RedeemCode;
            var RedeemCode = _redeemCodeRepository.GetByName(redeemCodeFromReq);
            if (RedeemCode == null)
            {
                //out message the code is expird 
                // return view
                return View("New");
            }
            else if (RedeemCode.isAvalible == false)
            {
                // Ur Code is Expired
                // return view
                return View("New");
            }

            var Package = _packageRepository.GetByName(RedeemCode.PackageName);
            var Category = _categoryRepository.GetByName(CourseFromReq.Name);

            CourseFromReq.NumberOfAssessment = Package.NumberOfAssesments;
            CourseFromReq.NumberOfLessons = Package.NumberOfLessons;
            CourseFromReq.NumberOfTrainees = Package.NumberOfTrainees;
            CourseFromReq.Hours = Package.Hours;
            CourseFromReq.TotalFilesSize = Package.TotlaFileSize;
            CourseFromReq.CourseImagePath = Category.Image;
            CourseFromReq.CreatedAt = "Created At " + DateTime.Now;
            CourseFromReq.instructorId = (int)instructorId;
            RedeemCode.isAvalible = false;
       
            _courseRepository.Insert(CourseFromReq);
            _courseRepository.Save();

            return RedirectToAction("Index", "Course");
        }

        public IActionResult ChaptersInCourse(int courseId)
        {
            var course = _courseRepository.GetById(courseId);
            if (course == null)
            {
                return NotFound();
            }

            var chapters = _chapterRepository.GetAll().Where(c => c.CourseId == courseId).ToList();

            ViewBag.CourseName = course.Name;
            ViewBag.CourseId = course.Id;

            return View(chapters);
        }


        public IActionResult LessonsInChapter(int chapterId)
        {
            var chapter = _chapterRepository.GetById(chapterId);
            if (chapter == null)
            {
                return NotFound();
            }

            var lessons = _lessonRepository.GetAll().Where(l => l.ChapterId == chapterId).ToList();
            ViewBag.ChapterName = chapter.Title;
            ViewBag.ChapterId = chapterId;  // Ensure ChapterId is set correctly

            return View(lessons);
        }



        public IActionResult TraineeCourse(int courseId)
        {
            var course = _courseRepositoryVersion2.GetCourseWithDetails(courseId);
            return View("TraineeCourse", course);
        }
        public IActionResult TraineeCourseList(int traineeId)
        {
            var course = _courseRepositoryVersion2.GetCourseTraineeWithDetails(traineeId);
            return View("TraineeCourseList", course);

        }


        // GET: Course/Edit
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var course = _courseRepository.GetById(id);
            if (course == null)
            {
                return NotFound();
            }
            return View(course);
        }

        // POST: Course/Edit
        [HttpPost]
        public IActionResult Edit(Course course)
        {
            if (ModelState.IsValid)
            {
                _courseRepository.Update(course);
                _courseRepository.Save();
                return RedirectToAction("Index");
            }
            return View(course);
        }

        // POST: Course/Delete
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var course = _courseRepository.GetById(id);
            if (course != null)
            {
                course.IsDeleted = true;
                _courseRepository.Update(course);
                _courseRepository.Save();
                return RedirectToAction("Index");
            }
            return NotFound();
        }

    }
}
