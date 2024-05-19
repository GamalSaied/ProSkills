using Microsoft.AspNetCore.Mvc;
using ProSkills.Interfaces;
using ProSkills.Models.ClientSide;
using ProSkills.Repository;
namespace ProSkills.Controllers;

public class TraineeController : Controller
{

    private IRepository<Trainee> _TraineeRepository;

    public TraineeController(IRepository<Trainee> TraineeRepository)
    {
        _TraineeRepository = TraineeRepository;
    }

    public IActionResult index()
    {
        List<Trainee> Trainees = _TraineeRepository.GetAll();
        return View("index", Trainees);
    }
}

