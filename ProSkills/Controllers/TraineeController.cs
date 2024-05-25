using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using ProSkills.Interfaces;
using ProSkills.Models.ClientSide;
using ProSkills.Repository;
namespace ProSkills.Controllers;

public class TraineeController : Controller
{

    private readonly ITraineeRepository  _traineeRepository;
    private readonly IRepository<Course> _courseRepository;
    private readonly IRepository<CourseTrainee> _courseTraineeRepository;

    public TraineeController(ITraineeRepository traineeRepository, IRepository<Course> courseRepository, IRepository<CourseTrainee> courseTraineeRepository )
    {
        _traineeRepository = traineeRepository;
        _courseRepository = courseRepository;
        _courseTraineeRepository = courseTraineeRepository;
    }

    public IActionResult index()
    {
        var trainees = _traineeRepository.GetAll();
        return View("index", trainees);
    }
    public IActionResult CoursesForTrainee(int traineeId)
    {
        var trainee = _traineeRepository.GetById(traineeId);
        if (trainee == null)
        {
            return NotFound();
        }

        var courses = trainee.Courses.Select(ct => ct.Course).ToList();
        ViewBag.TraineeName = trainee.Name;
        return View(courses);
    }

}

