using Microsoft.AspNetCore.Mvc;
using ProSkills.Interfaces;
using ProSkills.Models.ClientSide;
using ProSkills.Repository;

namespace ProSkills.Controllers
{
    public class RedeemCodeController : Controller
    {
        private readonly IRepository<RedeemCode> _RedeemCodeRepository;  

        public RedeemCodeController(IRepository<RedeemCode> RedeemCodeRepository)
        {
            _RedeemCodeRepository = RedeemCodeRepository;
           
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

            return View("New");
        }

        //press submit button

        //action saveNew

        [HttpPost]//action attribute
        public IActionResult SaveNew(RedeemCode RedeemCodefromreq)
        {

            if (ModelState.IsValid)
            {
                RedeemCodefromreq.CreatedAt = "Created At " + DateTime.Now;
                _RedeemCodeRepository.Insert(RedeemCodefromreq);
                _RedeemCodeRepository.Save();

                return RedirectToAction("Index", "RedeemCode");
            }


            return View("New", RedeemCodefromreq);
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
