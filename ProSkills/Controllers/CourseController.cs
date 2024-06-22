using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProSkills.Interfaces;
using ProSkills.Models.ClientSide.Enumerators;
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
        private ITraineeRepository _traineeRepository;
        private readonly ICourseTraineeRepository _courseTraineeRepository; // Use the specific interface

        private IRepository<Category> _categoryRepository;
        private IRepository<RedeemCode> _redeemCodeRepository;
        private IRepository<Package> _packageRepository;
        private IRepository<Chapter> _chapterRepository;
        private ICourseRepository _courseRepositoryVersion2;

        private readonly IRepository<Lesson> _lessonRepository;

        private readonly ITIContext _context;

        public CourseController(ITraineeRepository traineeRepository, ICourseTraineeRepository courseTraineeRepository,IRepository<Lesson> lessonRepository,IRepository<Chapter> chapterRepository, IRepository<Course> CourseRepository, IRepository<instructor> InstructorRepository, IRepository<Category> CategoryRepository, IRepository<RedeemCode> RedeemCodeRepository, IRepository<Package> PackageRepository , ICourseRepository courseRepositoryVersion2)
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
            ViewBag.CourseId = courseId;  // Ensure CourseId is set correctly

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
            var Instructors= _instructorRepository.GetAll();

            ViewBag.Instructors = Instructors;
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
        public IActionResult SoftDelete(int id)
        {
            var course = _courseRepository.GetById(id);
            if (course == null)
            {
                return Json(new { success = false, message = "Course not found." });
            }

            course.IsDeleted = true;
            try
            {
                _courseRepository.Update(course);
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                // Log the exception (use your preferred logging framework)
                Console.WriteLine($"Error updating course: {ex.Message}");
                return Json(new { success = false, message = "An error occurred while deleting the course." });
            }
        }
        [HttpGet]
        public IActionResult Leaderboard(int CourseId, int page = 1, int pageSize = 10)
        {
            var course = _courseRepository.GetById(CourseId);
            if (course == null)
            {
                return NotFound();
            }

            // Get the current user's email
            var currentUserEmail = User.Identity.Name;

            // Get all course trainees with leaderboard data
            var allLeaderboard = _courseTraineeRepository.GetLeaderboardByCourse(CourseId);

            // Find the current user's leaderboard entry
            var currentUserLeaderboard = allLeaderboard.FirstOrDefault(l => l.Email == currentUserEmail);

            // Ensure the completion percentage is calculated correctly
            foreach (var item in allLeaderboard)
            {
                item.CompletionPercentage = CalculateCompletionPercentage(item.Points);
            }

            var totalItems = allLeaderboard.Count();
            var totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

            // Paginate the leaderboard
            var paginatedLeaderboard = allLeaderboard
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            // Ensure the current user's entry is at the top
            if (currentUserLeaderboard != null)
            {
                paginatedLeaderboard.Insert(0, currentUserLeaderboard);
                paginatedLeaderboard = paginatedLeaderboard.Distinct().ToList();
            }

            ViewBag.CourseName = course.Name;
            ViewBag.CourseId = CourseId;

            var model = new PagedLeaderboardViewModel
            {
                CurrentPage = page,
                PageSize = pageSize,
                TotalPages = totalPages,
                Leaderboard = paginatedLeaderboard,
                CurrentUser = currentUserLeaderboard
            };

            return View(model);
        }


        // GET: Course/Details/5
        public IActionResult Details(int id)
        {
            var course = _courseRepository.GetById(id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // GET: Course/AddPoints
        [HttpGet]
        public IActionResult AddPoints()
        {
            var viewModel = new AddPointsViewModel
            {
                Trainees = _traineeRepository.GetAll().Select(t => new SelectListItem
                {
                    Value = t.Email,
                    Text = t.Email
                }),
                Courses = _courseRepository.GetAll().Select(c => new SelectListItem
                {
                    Value = c.Name,
                    Text = c.Name
                })
            };

            return View(viewModel);
        }

        // POST: Course/AddPoints
        [HttpPost]
        public IActionResult AddPoints(AddPointsViewModel model)
        {
            if (ModelState.IsValid)
            {
                var trainee = _traineeRepository.GetAll().FirstOrDefault(t => t.Email == model.TraineeEmail);
                var course = _courseRepository.GetAll().FirstOrDefault(c => c.Name == model.CourseName);

                if (trainee == null || course == null)
                {
                    ModelState.AddModelError("", "Invalid Trainee or Course");
                    return View(model);
                }

                var courseTrainee = _courseTraineeRepository.GetAll().FirstOrDefault(ct => ct.TraineeId == trainee.Id && ct.CourseId == course.Id);
                if (courseTrainee == null)
                {
                    ModelState.AddModelError("", "Trainee is not enrolled in the course");
                    return View(model);
                }

                courseTrainee.Points += model.Points;
                _courseTraineeRepository.Update(courseTrainee);
                _courseTraineeRepository.Save();

                return RedirectToAction("Index1"); // Redirect to the desired action after saving the points
            }

            model.Trainees = _traineeRepository.GetAll().Select(t => new SelectListItem
            {
                Value = t.Email,
                Text = t.Email
            });
            model.Courses = _courseRepository.GetAll().Select(c => new SelectListItem
            {
                Value = c.Name,
                Text = c.Name
            });

            return View(model);
        }
        private LeaderboardViewModel MapToLeaderboardViewModel(CourseTrainee ct, int rank)
        {
            var viewModel = new LeaderboardViewModel
            {
                Rank = rank,
                ProfilePictureUrl = ct.Trainee?.ProfilePictureUrl,
                FullName = ct.Trainee?.Name,
                Points = ct.Points,
                Level = GetLevel(ct.Points),
                CompletionPercentage = CalculateCompletionPercentage(ct.Points)
            };

            return viewModel;
        }

        private Level GetLevel(int points)
        {
            if (points > 700) return Level.Legendary;
            if (points > 400) return Level.Professional;
            if (points > 200) return Level.Semi_Pro;
            if (points > 50) return Level.Amature;
            return Level.Beginner;
        }


        private int CalculateCompletionPercentage(int points)
        {
            if (points > 700) return 100;
            if (points > 400) return (int)((points - 400) / 3.0);
            if (points > 200) return (int)((points - 200) / 2.0);
            if (points > 50) return (int)((points - 50) / 1.5);
            return (int)(points * 2);  // For Beginner level
        }


        public IActionResult Cards()
        {
            var courses = _courseRepository.GetAll().Where(c => !c.IsDeleted);
            var courseViewModels = courses.Select(course => new CourseViewModel
            {
                Id = course.Id,
                Title = course.Name,
                Description = course.Description,
                Price = course.Price,
                ImagePath = string.IsNullOrEmpty(course.CourseImagePath) ? "/Images/DefaultCourseImg.png" : course.CourseImagePath,
                VendorName = course.Instructor?.Name ?? "Unknown Vendor",
                Duration = course.Hours ?? 0,
                StudentCount = course.NumberOfTrainees ?? 0,
                Rating = course.Rating,
                ReviewCount = course.ReviewCount,
                StartAt = course.StartAt,
                EndAt = course.EndAt,
                Location = course.Location,
                NumberOfAssessment = course.NumberOfAssessment ?? 0,
                NumberOfLessons = course.NumberOfLessons ?? 0,
                TotalFilesSize = course.TotalFilesSize ?? 0,
                Chapters = course.Chapters?.Select(ch => new ChapterViewModel
                {
                    Id = ch.Id,
                    Title = ch.Title,
                    Description = ch.Description
                }).ToList() ?? new List<ChapterViewModel>(),
                Assessments = course.Assessments?.Select(a => new AssessmentViewModel
                {
                    Id = a.Id,
                    Title = a.Title,
                    Description = a.Description,
                    Points = a.Points
                }).ToList() ?? new List<AssessmentViewModel>(),
                Instructor = course.Instructor == null ? new InstructorViewModel() : new InstructorViewModel
                {
                    Id = course.Instructor.Id,
                    Name = course.Instructor.Name,
                    ImagePath = string.IsNullOrEmpty(course.Instructor.ImagePath) ? "\\ThemeFront\\img\\User.jpg" : course.Instructor.ImagePath,
                    Bio = course.Instructor.Bio,
                    Speciallization = course.Instructor.Speciallization
                }
            }).ToList();

            if (!courseViewModels.Any())
            {
                return View("NoCourses");
            }

            return View(courseViewModels);
        }





        [HttpPost]
        public IActionResult Create(CourseViewModel courseViewModel)
        {
            if (ModelState.IsValid)
            {
                var course = new Course
                {
                    Name = courseViewModel.Title,
                    Description = courseViewModel.Description,
                    CourseImagePath = courseViewModel.ImagePath,
                    instructorId = 1, // Assign appropriate instructor ID
                    StartAt = courseViewModel.StartAt,
                    EndAt = courseViewModel.EndAt,
                    Location = courseViewModel.Location,
                    Hours = (int?)courseViewModel.Duration, // Assuming Hours is the duration
                    NumberOfTrainees = courseViewModel.StudentCount
                };

                _courseRepository.Insert(course);
                _courseRepository.Save();

                return RedirectToAction("Cards"); // Redirect to the new card view
            }

            return View(courseViewModel);
        }


        public IActionResult Profile(int id)
        {
            var course = _courseRepository.GetById(id);
            if (course == null)
            {
                return NotFound();
            }

            var courseViewModel = new CourseViewModel
            {
                Id = course.Id,
                Title = course.Name,
                Description = course.Description,
                Price = course.Price,
                ImagePath = string.IsNullOrEmpty(course.CourseImagePath) ? "/Images/DefaultCourseImg.png" : course.CourseImagePath,
                VendorName = course.Instructor?.Name ?? "Unknown Vendor",
                Duration = course.Hours ?? 0,
                StudentCount = course.NumberOfTrainees ?? 0,
                Rating = course.Rating,
                ReviewCount = course.ReviewCount,
                StartAt = course.StartAt,
                EndAt = course.EndAt,
                Location = course.Location,
                NumberOfAssessment = course.NumberOfAssessment ?? 0,
                NumberOfLessons = course.NumberOfLessons ?? 0,
                TotalFilesSize = course.TotalFilesSize ?? 0,
                Chapters = course.Chapters?.Select(ch => new ChapterViewModel
                {
                    Id = ch.Id,
                    Title = ch.Title,
                    Description = ch.Description
                }).ToList() ?? new List<ChapterViewModel>(),
                Assessments = course.Assessments?.Select(a => new AssessmentViewModel
                {
                    Id = a.Id,
                    Title = a.Title,
                    Description = a.Description,
                    Points = a.Points
                }).ToList() ?? new List<AssessmentViewModel>(),
                Instructor = course.Instructor == null ? new InstructorViewModel() : new InstructorViewModel
                {
                    Id = course.Instructor.Id,
                    Name = course.Instructor.Name,
                    ImagePath = string.IsNullOrEmpty(course.Instructor.ImagePath) ? "\\ThemeFront\\img\\User.jpg" : course.Instructor.ImagePath,
                    Bio = course.Instructor.Bio,
                    Speciallization = course.Instructor.Speciallization
                }
            };

            return View(courseViewModel);
        }





    }


}



