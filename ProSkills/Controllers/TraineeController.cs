using Microsoft.AspNetCore.Mvc;
using ProSkills.Interfaces;
using ProSkills.Models.ClientSide;

namespace ProSkills.Controllers
{
    public class TraineeController : Controller
    {
       
        ITraineeRepository TraineeRepository;
        ICourseRepository CourseRepository;
        //Initialization
        //inject -- ask
        //don't create ask or injection in constructor 
        public TraineeController
            (ITraineeRepository _traineeRepository, ICourseRepository _CourseRepository)
        {
            TraineeRepository = _traineeRepository;
            CourseRepository = _CourseRepository;
     
        }


        //Trainee/index
        //action to return all the trainees
        public IActionResult Index()
        {

            List<Trainee> traineerList = TraineeRepository.Getall();
            //List<Trainee> traineerList = context.Trainee.ToList();

            return View("Index", traineerList);
        }

     
        //action to return a sepecific instructor with id
        public IActionResult Details(int id)
        {
            Trainee traineeid = TraineeRepository.GetbyId(id);
            //Trainee traineeid = context.Trainee.FirstOrDefault(d => d.Id == id);

            return View("Details", traineeid);//view Details ,Model =traineeid
        }

        //press anchor tag

        [HttpGet]
        public IActionResult New()
        {
            return View("New");
        }

        //press submit button
        //Instructor/SaveNEw?Name=SD&ManagerName=Ahmed
        //action saveNew
        [HttpPost]//action attribute
        public IActionResult SaveNew(Trainee traineereq)
        {
            if (traineereq.Name != null)
            {
                TraineeRepository.Insert(traineereq);
                TraineeRepository.Save();
                //context.Add(instructreq);
                //context.SaveChanges();
                return RedirectToAction("Index", "Trainee");
            }

            return View("New", traineereq);
        }
    }
}
