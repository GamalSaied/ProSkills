using Microsoft.AspNetCore.Mvc;
using ProSkills.Interfaces;
using ProSkills.Models.ClientSide;
using ProSkills.Repository;

namespace ProSkills.Controllers
{
    public class PackageController : Controller
    {
        IRepository<Package> _PackageRepository;

        public PackageController(IRepository<Package> PackageRepository)
        {
            _PackageRepository = PackageRepository;

        }
        public IActionResult Index()
        {
            List<Package> Packages = _PackageRepository.GetAll();


            return View("Index", Packages);

        }
        [HttpPost]//action attribute
        public ActionResult Delete(int id)
        {

            var Package = _PackageRepository.GetById(id);
            if (Package == null)
            {
                return NotFound();
            }


            _PackageRepository.Delete(id);
            _PackageRepository.Save();

            return RedirectToAction("Index"); // Redirect to the list of Packages after deletion
        }


        [HttpGet]
        public IActionResult New()
        {
           
            return View("New");
        }

        //press submit button
        
        //action saveNew

        [HttpPost]//action attribute
        public IActionResult SaveNew(Package Packagreq)
        {
           
            if (ModelState.IsValid)
            {
                Packagreq.CreatedAt = "Created At " + DateTime.Now;
                _PackageRepository.Insert(Packagreq);
                _PackageRepository.Save();

                return RedirectToAction("Index", "Package");
            }


            return View("New", Packagreq);
        }


        public IActionResult Edit(int id)
        {
            //Get data

            var Package = _PackageRepository.GetById(id);

            return View("Edit", Package);                  //Open Edit Page


        }



        public IActionResult SaveEdit(Package Packagereq)
        {
            var Packageformdb = _PackageRepository.GetById(Packagereq.Id);
            Packageformdb.Name = Packagereq.Name;
            Packageformdb.Image = Packagereq.Image;
            Packageformdb.CreatedAt="Edited" +DateTime.Now;

            if (ModelState.IsValid)
            {
                try
                {

                    _PackageRepository.Save();
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", "Something Went wrong Please Make Sure you set Everything right");
                }
            }

            return View("Edit", Packagereq);
        }
    }
}
