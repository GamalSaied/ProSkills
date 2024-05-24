using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProSkills.Interfaces;
using ProSkills.Models.ClientSide;
using ProSkills.Repository;

namespace ProSkills.Controllers
{
    public class RedeemCodeController : Controller
    {
        private readonly IRepository<RedeemCode> _RedeemCodeRepository;
        private readonly IRepository<Package> _PackageRepository;

        public RedeemCodeController(IRepository<RedeemCode> RedeemCodeRepository, IRepository<Package> PackageRepository)
        {
            _RedeemCodeRepository = RedeemCodeRepository;
            _PackageRepository = PackageRepository;

        }
        public IActionResult Index()
        {

            List<RedeemCode> RedeemCodes = _RedeemCodeRepository.GetAll();
            return View("Index", RedeemCodes);

        }

  
        [HttpPost]//action attribute
        public ActionResult Delete(int id)
        {

            var Package = _RedeemCodeRepository.GetById(id);
            if (Package == null)
            {
                return NotFound();
            }


            _RedeemCodeRepository.Delete(id);
            _RedeemCodeRepository.Save();

            return RedirectToAction("Index"); 
        }


        [HttpGet]
        public IActionResult New()
        {

            // Send Combobox Data to View
            List<Package> PackageData = _PackageRepository.GetAll().ToList();
            List<SelectListItem> PackageNames = PackageData
                .Select(c => new SelectListItem { Text = c.Name, Value = c.Name })
                .ToList();

            // Send Data To View
            ViewBag.PackageNames = PackageNames;

            return View("New");

        }


        [HttpPost]//action attribute
        public IActionResult SaveNew(RedeemCode RedeemCodefromreq)
        {

                // Create GUID 
                string uniqueGuid = "PRO" + (Guid.NewGuid().ToString()).Substring(0,4);
                // Insert Data to Database

                RedeemCodefromreq.Code = uniqueGuid;
                RedeemCodefromreq.isAvalible = true; 
                RedeemCodefromreq.CreatedAt = "Created At " + DateTime.Now;

                _RedeemCodeRepository.Insert(RedeemCodefromreq);
                _RedeemCodeRepository.Save();
                 return RedirectToAction("Index", "RedeemCode");

        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            //Get data

            var redeemcode = _RedeemCodeRepository.GetById(id);

            return View("Edit", redeemcode);          //Open Edit Page
        }



        [HttpPost]//action attribute
        public IActionResult SaveEdit(RedeemCode RedeemCodefromreq)
        {
            var RedeemCodeformdb = _RedeemCodeRepository.GetById(RedeemCodefromreq.Id);
            RedeemCodeformdb.Code = RedeemCodefromreq.Code;
            RedeemCodeformdb.PackageName = RedeemCodefromreq.PackageName;
            RedeemCodeformdb.CreatedAt = "Edited" + DateTime.Now;


            if (ModelState.IsValid)
            {
                try
                {

                    _RedeemCodeRepository.Save();
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", "Something Went wrong Please Make Sure you set Everything right");

                }
            }

            return View("Edit", RedeemCodefromreq);
        }
    }
}
