using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProSkills.Interfaces;
using ProSkills.Models.AdminPanel.InstructorManger;
using ProSkills.Models.ClientSide;
using ProSkills.Repositories;
using ProSkills.Repository;
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

        private IRepository<Category> _categoryRepository;
        private IRepository<RedeemCode> _redeemCodeRepository;
        private IRepository<Package> _packageRepository;
        private IRepository<Chapter> _chapterRepository;

        private ICourseRepository _courseRepositoryVersion2;

        private readonly IRepository<Lesson> _lessonRepository;

        private readonly ITIContext _context;

        public CourseController(IRepository<Lesson> lessonRepository,IRepository<Chapter> chapterRepository, IRepository<Course> CourseRepository, IRepository<instructor> InstructorRepository, IRepository<Category> CategoryRepository, IRepository<RedeemCode> RedeemCodeRepository, IRepository<Package> PackageRepository , ICourseRepository courseRepositoryVersion2)
        {
            _courseRepository = CourseRepository;
            _instructorRepository = InstructorRepository;
            _categoryRepository = CategoryRepository;
            _redeemCodeRepository = RedeemCodeRepository;
            _packageRepository = PackageRepository;
            _chapterRepository = chapterRepository;
            _lessonRepository = lessonRepository;
            _courseRepositoryVersion2 = courseRepositoryVersion2;

        }
        #endregion

        public IActionResult TraineesInCourse(int courseId)
        {
            var course = _courseRepository.GetById(courseId);
            if (course == null)
            {
                return NotFound();
            }

            var trainees = course.Trainees.Select(ct => ct.Trainee).ToList();
            ViewBag.CourseName = course.Name;
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



        public IActionResult ChaptersInCourse(int courseId)
        {
            var course = _courseRepository.GetById(courseId);
            if (course == null)
            {
                return NotFound();
            }

            var chapters = _chapterRepository.GetAll().Where(c => c.CourseId == courseId).ToList();

            ViewBag.CourseName = course.Name;
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
            return View(lessons);
        }

        public IActionResult SaveNew(Course CourseFromReq,int instructorId)  // Get_InstructorID from Hidden
        {
            string redeemCodeFromReq = CourseFromReq.RedeemCode;
            var RedeemCode = _redeemCodeRepository.GetByName(redeemCodeFromReq);
            if (RedeemCode == null) 
            {
                //out message the code is expird 
                // return view
                return View("New");
            }
            else if (RedeemCode.isAvalible ==false)
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

        public IActionResult TraineeCourse(int courseId)
        {
            var course = _courseRepositoryVersion2.GetCourseWithDetails(courseId);
            return View("TraineeCourse", course);
        }

 




    }
}
