using Microsoft.AspNetCore.Mvc;
using ProSkills.Interfaces;
using ProSkills.Models.ClientSide;

namespace ProSkills.Controllers
{
    public class CourseController : Controller
    {
        ////Default for reference = null

        //ICourseRepository CourseRepository;

        //public CourseController(ICourseRepository _CourseRepository)


        //{
        //    CourseRepository = _CourseRepository;

        //    //CourseRepository = new CourseRepository();
        //}
        //public IActionResult Index()
        //{
        //    var courselist = CourseRepository.Getall();
        //    //var courselist =context.Course.ToList();    

        //    return View("Index", courselist);//pagination

        //}

        ////action to return a sepecific COURSE with id
        //public IActionResult Details(int id)
        //{
        //    //ITIContext context = new ITIContext();

        //    Course CRSid = CourseRepository.GetById(id);

    

        //    return View("Details", CRSid);//view Details ,Model =instructorid
        //}

        ////press anchor tag

        //[HttpGet]
        //public IActionResult New()
        //{

        //    ViewData["courseList"] = CourseRepository.Getall();
        //    //ViewData["courseList"]=context.Course.ToList();
        //    return View("New"); //view with the same action name "New" ,Model = null
        //}

      

        //[HttpPost]//action attribute
        //public IActionResult SaveNew(Course CrsFromreq)
        //{
        //    if (ModelState.IsValid == true)
        //    {
        //        CourseRepository.Insert(CrsFromreq);
        //        CourseRepository.Save();
        //        //context.Course.Add(CrsFromreq);
        //        //context.SaveChanges();
        //        return RedirectToAction("Index", "Course");
        //    }
        //    ViewData["courseList"] = CourseRepository.Getall();
        //    //ViewData["courseList"] = context.Course.ToList();
        //    return View("New", CrsFromreq);
        //}

        //public IActionResult CheckName(string name)
        //{
        //    Course course = CourseRepository.checkName(name);
        //    //Course course = context.Course.FirstOrDefault(e => e.Name.ToLower() == name.ToLower());
        //    if (course == null) { return Json(true); }
        //    { return Json(false); }
        //}

    }
}
