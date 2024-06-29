using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
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
        private readonly IActivityLogRepository _activityLogRepository;
        private readonly IRepository<Assessment> _assessmentRepository;

        private IRepository<Category> _categoryRepository;
        private IRepository<RedeemCode> _redeemCodeRepository;
        private IRepository<Package> _packageRepository;
        private IRepository<Chapter> _chapterRepository;
        private ICourseRepository _courseRepositoryVersion2;
        private readonly UserManager<ApplicationUser> _userManager;

        private readonly IRepository<Lesson> _lessonRepository;
        private readonly IWebHostEnvironment _environment;

        private readonly IJoinRequestRepository _joinRequestRepository;

        public CourseController(IRepository<Assessment> assessmentRepository,IJoinRequestRepository joinRequestRepository
,IWebHostEnvironment environment,IActivityLogRepository activityLogRepository , UserManager<ApplicationUser> userManager,ITraineeRepository traineeRepository, ICourseTraineeRepository courseTraineeRepository,IRepository<Lesson> lessonRepository,IRepository<Chapter> chapterRepository, IRepository<Course> CourseRepository, IRepository<instructor> InstructorRepository, IRepository<Category> CategoryRepository, IRepository<RedeemCode> RedeemCodeRepository, IRepository<Package> PackageRepository , ICourseRepository courseRepositoryVersion2)
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
            _activityLogRepository = activityLogRepository;
            _environment = environment;
            _userManager = userManager;
            _joinRequestRepository = joinRequestRepository;

            _assessmentRepository = assessmentRepository;

        }
        [Authorize]
        public async Task<IActionResult> AssessmentsInCourse(int courseId)
        {
            var course = _courseRepository.GetById(courseId);
            if (course == null)
            {
                return NotFound();
            }

            var assessments = _assessmentRepository.GetAll().Where(a => a.CourseId == courseId).ToList();

            var viewModel = new AssessmentsInCourseViewModel
            {
                CourseId = course.Id,
                CourseTitle = course.Name,
                Assessments = assessments.Select(a => new AssessmentViewModel
                {
                    Id = a.Id,
                    Title = a.Title,
                    Description = a.Description,
                    Points = a.Points
                }).ToList()
            };

            return View(viewModel);
        }

        [Authorize]
        public IActionResult ViewAssessment(int id)
        {
            var assessment = _assessmentRepository.GetById(id);
            if (assessment == null)
            {
                return NotFound();
            }

            var viewModel = new AssessmentViewModel
            {
                Id = assessment.Id,
                Title = assessment.Title,
                Description = assessment.Description,
                Points = assessment.Points
            };

            return View(viewModel);
        }
        public async Task<IActionResult>Join(int id)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var trainee = _traineeRepository.GetTraineeByEmail(user.Email);
            if (trainee == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var course = _courseRepository.GetById(id);
            if (course == null)
            {
                return NotFound();
            }

            var viewModel = new JoinRequestViewModel
            {
                CourseId = course.Id,
                CourseTitle = course.Name,
                TraineeId = trainee.Id,
                TraineeEmail = trainee.Email
            };

            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> SubmitJoinRequest(JoinRequestViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Join", model);
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var trainee = _traineeRepository.GetTraineeByEmail(user.Email);
            if (trainee == null)
            {
                return RedirectToAction("Index", "Home");
            }

            // Check if there is already a pending join request for this course and trainee
            var existingRequest = _joinRequestRepository.GetAll()
                .FirstOrDefault(jr => jr.CourseId == model.CourseId && jr.TraineeId == trainee.Id && jr.Status == JoinRequestStatus.Pending);

            if (existingRequest != null)
            {
                return View("AlreadySubmittedRequest");
            }

            string paymentProofPath = null;

            if (model.PaymentProof != null && model.PaymentProof.Length > 0)
            {
                var uploadsFolder = Path.Combine(_environment.WebRootPath, "payment_proofs");
                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                var uniqueFileName = Guid.NewGuid().ToString() + "_" + model.PaymentProof.FileName;
                var fullPath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    await model.PaymentProof.CopyToAsync(fileStream);
                }

                paymentProofPath = Path.Combine("\\payment_proofs", uniqueFileName);
            }

            var joinRequest = new JoinRequest
            {
                CourseId = model.CourseId,
                TraineeId = trainee.Id,
                PaymentProofPath = paymentProofPath,
                Status = JoinRequestStatus.Pending,
                CreatedAt = DateTime.Now
            };

            _joinRequestRepository.Insert(joinRequest);
            _joinRequestRepository.Save();

            // Send email or notification to admin for approval if necessary

            return RedirectToAction("JoinRequestSubmitted");
        }
        [Authorize]
        public IActionResult JoinRequestSubmitted()
        {
            return View();
        }

        //[Authorize(Roles = "Admin")]
        public IActionResult PendingRequests()
        {
            var pendingRequests = _joinRequestRepository.GetAll().Where(jr => jr.Status == JoinRequestStatus.Pending).ToList();
            return View(pendingRequests);
        }

        //[Authorize(Roles = "Admin")]
        public IActionResult ApproveJoinRequest(int id)
        {
            var joinRequest = _joinRequestRepository.GetById(id);
            if (joinRequest == null)
            {
                return NotFound();
            }

            joinRequest.Status = JoinRequestStatus.Approved;
            _joinRequestRepository.Update(joinRequest);
            _joinRequestRepository.Save();

            var courseTrainee = new CourseTrainee
            {
                CourseId = joinRequest.CourseId,
                TraineeId = joinRequest.TraineeId,
                CompletionRatio = 0,
                Points = 0
            };

            // Assuming you have a CourseTraineeRepository, insert the new record
            _courseTraineeRepository.Insert(courseTrainee);
            _courseTraineeRepository.Save();

            return RedirectToAction("PendingRequests");
        }

        [HttpPost]
        public IActionResult DeclineJoinRequest(int id)
        {
            var joinRequest = _joinRequestRepository.GetById(id);
            if (joinRequest == null)
            {
                return NotFound();
            }

            _joinRequestRepository.Delete(id);
            _joinRequestRepository.Save();

            return RedirectToAction("PendingRequests");
        }

        #endregion

        [Authorize]
        public async Task<IActionResult> Dashboard(int courseId)
        {
            var course = _courseRepository.GetById(courseId);
            if (course == null)
            {
                throw new KeyNotFoundException($"Course with Id {courseId} not found.");
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }

            // Calculate completion ratio
            var completionRatio = GetCompletionRatio(course, user.Email);

            // Update CourseTrainee completion ratio
            var courseTrainee = _courseTraineeRepository.GetByUserEmailAndCourse(user.Email, courseId);
            if (courseTrainee != null)
            {
                courseTrainee.CompletionRatio = completionRatio;
                _courseTraineeRepository.Update(courseTrainee);
                _courseTraineeRepository.Save();
            }

            var completedLessons = _activityLogRepository.GetByUserIdAndCourseId(user.Email, courseId)
                                            .Select(al => al.LessonId)
                                            .ToList();

            var viewModel = new CourseViewModel
            {
                Id = course.Id,
                Title = course.Name ?? "No Title",
                Description = course.Description ?? "No Description",
                Duration = course.Hours ?? 0,
                StudentCount = course.NumberOfTrainees ?? 0,
                Rating = course.Rating,
                ReviewCount = course.ReviewCount,
                StartAt = course.StartAt,
                EndAt = course.EndAt,
                Location = course.Location ?? "No Location",
                ImagePath = course.CourseImagePath ?? "\\Images\\DefaultCourseImg.png",
                Chapters = course.Chapters?.Select(c => new ChapterViewModel
                {
                    Id = c.Id,
                    Title = c.Title ?? "No Title",
                    Description = c.Description ?? "No Description",
                    Lessons = c.Lessons?.Select(l => new LessonViewModel
                    {
                        Id = l.Id,
                        Title = l.Title ?? "No Title",
                        Content = l.Content ?? "No Content",
                        DownloadLink = l.downloadLink,
                        TaskLink = l.TaskLink,
                        Time = l.Time ?? TimeSpan.Zero,
                        IsCompleted = completedLessons.Contains(l.Id) // Check if the lesson is completed
                    }).ToList() ?? new List<LessonViewModel>()
                }).ToList() ?? new List<ChapterViewModel>(),
                Instructor = new InstructorViewModel
                {
                    Id = course.Instructor?.Id ?? 0,
                    Name = course.Instructor?.Name ?? "Unknown Instructor",
                    ImagePath = course.Instructor?.ImagePath ?? "\\ThemeFront\\img\\User.jpg",
                    Bio = course.Instructor?.Bio ?? "No bio available.",
                    Speciallization = course.Instructor?.Speciallization ?? "N/A"
                },
                CompletionRatio = completionRatio
            };

            return View(viewModel);
        }


        [HttpPost]
        public IActionResult UpdateLessonCompletion(int lessonId, bool isChecked)
        {
            var user = _userManager.GetUserAsync(User).Result;
            if (user == null)
            {
                return Json(new { success = false, message = "User not found." });
            }

            var lesson = _lessonRepository.GetById(lessonId);
            if (lesson == null)
            {
                return Json(new { success = false, message = "Lesson not found." });
            }

            var activityLog = _activityLogRepository.GetByUserIdAndLessonId(user.Email, lessonId);
            if (isChecked)
            {
                if (activityLog == null)
                {
                    _activityLogRepository.Insert(new ActivityLog
                    {
                        UserEmail = user.Email,
                        ActivityDate = DateTime.Now,
                        ActivityType = "LessonCompleted",
                        Description = $"Completed lesson {lesson.Title}",
                        LessonId = lessonId
                    });
                }
            }
            else
            {
                if (activityLog != null)
                {
                    _activityLogRepository.Delete(activityLog.Id);
                }
            }

            _activityLogRepository.Save();

            // Update CourseTrainee Completion Ratio
            var courseTrainee = _courseTraineeRepository.GetByUserEmailAndCourse(user.Email, lesson.Chapter.CourseId);
            if (courseTrainee != null)
            {
                var course = _courseRepository.GetById(lesson.Chapter.CourseId);
                var completionRatio = GetCompletionRatio(course, user.Email);
                courseTrainee.CompletionRatio = completionRatio;
                _courseTraineeRepository.Update(courseTrainee);
                _courseTraineeRepository.Save();
                return Json(new { success = true, completionRatio = (int)completionRatio });
            }

            return Json(new { success = false, message = "CourseTrainee not found." });
        }





        private double GetCompletionRatio(Course course, string userEmail)
        {
            var totalLessons = course.Chapters?.SelectMany(c => c.Lessons).Count() ?? 0;
            if (totalLessons == 0)
            {
                return 0;
            }

            var completedLessons = _activityLogRepository.GetByUserIdAndCourseId(userEmail, course.Id).Count();
            return (completedLessons / (double)totalLessons) * 100;
        }




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

        [HttpGet]
        public IActionResult AddPoints()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPoints(AddPointsViewModel model)
        {
            var user = _userManager.FindByEmailAsync(model.Email).Result;
            if (user == null)
            {
                return RedirectToAction("GetPoints", new { error = "EmailNotValid" });
            }

            if (!_userManager.CheckPasswordAsync(user, model.Password).Result)
            {
                return RedirectToAction("GetPoints", new { error = "PassNotValid" });
            }

            var course = _courseRepository.GetAll().FirstOrDefault(c => c.Name == model.CourseName);
            if (course == null)
            {
                return RedirectToAction("GetPoints", new { error = "CourseNotFound" });
            }

            var trainee = _traineeRepository.GetAll().FirstOrDefault(t => t.Email == model.Email);
            var courseTrainee = _courseTraineeRepository.GetAll().FirstOrDefault(ct => ct.TraineeId == trainee.Id && ct.CourseId == course.Id);
            if (courseTrainee == null)
            {
                return RedirectToAction("GetPoints", new { error = "TraineeNotEnrolledInCourse" });
            }

            // Add points to the trainee
            courseTrainee.Points += model.Points;
            _courseTraineeRepository.Update(courseTrainee);
            _courseTraineeRepository.Save();

            return RedirectToAction("GetPoints", new { courseId = course.Id, traineeId = trainee.Id });
        }
        public async Task<IActionResult> CoursesByCategory(int categoryId)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var trainee = _traineeRepository.GetAll().FirstOrDefault(t => t.Email == user.Email);
            if (trainee == null)
            {
                return View(new CoursesByCategoryViewModel { EnrolledCourses = new List<CourseViewModel>(), OtherCourses = new List<CourseViewModel>(), CategoryName = "Category Not Found" });
            }

            var category = _categoryRepository.GetById(categoryId);
            if (category == null)
            {
                return View(new CoursesByCategoryViewModel { EnrolledCourses = new List<CourseViewModel>(), OtherCourses = new List<CourseViewModel>(), CategoryName = "Category Not Found" });
            }

            var coursesInCategory = _courseRepository.GetAll().Where(c => c.CategoryId == categoryId).ToList();

            var enrolledCourses = coursesInCategory
                .Where(c => _courseTraineeRepository.GetAll().Any(ct => ct.CourseId == c.Id && ct.TraineeId == trainee.Id))
                .Select(course => new CourseViewModel
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
                    IsEnrolled = true,
                    CompletionRatio = _courseTraineeRepository.GetByUserEmailAndCourse(user.Email, course.Id)?.CompletionRatio ?? 0,
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

            var otherCourses = coursesInCategory
                .Where(c => !_courseTraineeRepository.GetAll().Any(ct => ct.CourseId == c.Id && ct.TraineeId == trainee.Id))
                .Select(course => new CourseViewModel
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
                    IsEnrolled = false,
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

            var viewModel = new CoursesByCategoryViewModel
            {
                EnrolledCourses = enrolledCourses,
                OtherCourses = otherCourses,
                CategoryName = category.Name,
            CategoryDescription = category.Description

            };

            return View(viewModel);
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


        public async Task<IActionResult> Cards()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }

            // Get the Trainee associated with the user
            var trainee = _traineeRepository.GetAll().FirstOrDefault(t => t.Email == user.Email);
            if (trainee == null)
            {
                return View(new CoursesViewModel { EnrolledCourses = new List<CourseViewModel>(), OtherCourses = new List<CourseViewModel>() });
            }

            // Get the courses the trainee is enrolled in
            var enrolledCourses = _courseTraineeRepository.GetAll()
                .Where(ct => ct.TraineeId == trainee.Id)
                .Select(ct => ct.Course)
                .Distinct()
                .ToList();

            // Get the other available courses
            var otherCourses = _courseRepository.GetAll()
                .Where(c => !c.IsDeleted && !enrolledCourses.Select(ec => ec.Id).Contains(c.Id))
                .ToList();

            // Map the enrolled courses to CourseViewModel
            var enrolledCourseViewModels = enrolledCourses.Select(course => new CourseViewModel
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
                IsEnrolled = true,
                CompletionRatio = _courseTraineeRepository.GetByUserEmailAndCourse(user.Email, course.Id)?.CompletionRatio ?? 0,
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

            // Map the other available courses to CourseViewModel
            var otherCourseViewModels = otherCourses.Select(course => new CourseViewModel
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
                IsEnrolled = false,
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

            var viewModel = new CoursesViewModel
            {
                EnrolledCourses = enrolledCourseViewModels,
                OtherCourses = otherCourseViewModels
            };

            return View(viewModel);
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

        public IActionResult GetPoints(int? courseId = null, int? traineeId = null, string error = null)
        {
            if (!string.IsNullOrEmpty(error))
            {
                return View((object)error);
            }

            if (courseId == null || traineeId == null)
            {
                return NotFound();
            }

            var course = _courseRepository.GetById(courseId.Value);
            var trainee = _traineeRepository.GetById(traineeId.Value);

            if (course == null || trainee == null)
            {
                return NotFound();
            }

            var courseTrainee = _courseTraineeRepository.GetByUserEmailAndCourse(trainee.Email, courseId.Value);
            if (courseTrainee == null)
            {
                return NotFound();
            }

            var viewModel = new TraineeCourseDetailsViewModel
            {
                FullName = trainee.Name,
                Email = trainee.Email,
                CourseName = course.Name,
                Level = GetLevel(courseTrainee.Points),
                CompletionRatio = CalculateCompletionPercentage(courseTrainee.Points),
                Points = courseTrainee.Points,
                Rank = _courseTraineeRepository.GetLeaderboardByCourse(course.Id).FindIndex(l => l.Email == trainee.Email) + 1
            };

            return View(viewModel);
        }


        [HttpGet]
        public IActionResult GetTraineeDetails()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetTraineeDetails(string email, string password, string courseName)
        {
            var user = _userManager.FindByEmailAsync(email).Result;
            if (user == null)
            {
                return RedirectToAction("GetPoints", new { error = "EmailNotValid" });
            }

            if (!_userManager.CheckPasswordAsync(user, password).Result)
            {
                return RedirectToAction("GetPoints", new { error = "PassNotValid" });
            }

            var course = _courseRepository.GetAll().FirstOrDefault(c => c.Name == courseName);
            if (course == null)
            {
                return RedirectToAction("GetPoints", new { error = "CourseNotFound" });
            }

            var trainee = _traineeRepository.GetAll().FirstOrDefault(t => t.Email == email);
            var courseTrainee = _courseTraineeRepository.GetAll().FirstOrDefault(ct => ct.TraineeId == trainee.Id && ct.CourseId == course.Id);
            if (courseTrainee == null)
            {
                return RedirectToAction("GetPoints", new { error = "TraineeNotEnrolledInCourse" });
            }

            return RedirectToAction("GetPoints", new { courseId = course.Id, traineeId = trainee.Id });
        }

    }




}



