using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using ProSkills.Interfaces;
using ProSkills.Models.AdminPanel.InstructorManger;
using ProSkills.Models.ClientSide;
using ProSkills.Repository;

namespace ProSkills.Controllers
{
    public class CategoryController : Controller
    {
        IRepository<Category> _CategoryRepository;
      
        public CategoryController(IRepository<Category> CategoryRepository)
        {
            _CategoryRepository = CategoryRepository;

        }
        public IActionResult Index()
        {

            List<Category> Categories = _CategoryRepository.GetAll();
            return View("Index", Categories);

        }
        //[HttpPost]//action attribute
        //public ActionResult Delete(int id)
        //{
         
        //    var Category = _CategoryRepository.GetById(id);
        //    if (Category == null)
        //    {
        //        return NotFound();
        //    }


        //    _CategoryRepository.Delete(id);
        //    _CategoryRepository.Save();
          
        //    return RedirectToAction("Index"); // Redirect to the list of Categories after deletion
        //}


        //[HttpGet]
        //public IActionResult New()
        //{
            
        //    return View("New");
        //}

        //press submit button
        //Instructor/SaveNEw?Name=SD&ManagerName=Ahmed
        //action saveNew

        public IActionResult New()
        {
            return View("New");
        }

        [HttpPost]//action attribute
        public IActionResult SaveNew(Category CategoryFromReq)
        {
            if (CategoryFromReq.Name != null)
            {
                
                CategoryFromReq.CreatedAt = "Created At "+ DateTime.Now;
                _CategoryRepository.Insert(CategoryFromReq);
                _CategoryRepository.Save();
               
                return RedirectToAction("Index", "Category");
            }

            return View("New", CategoryFromReq);
        }


        public IActionResult Edit(int id)
        {
            //Get data           
            var Category = _CategoryRepository.GetById(id);
            return View("Edit", Category);                  
        }


      
        public IActionResult SaveEdit(Category categreq)
        {
            var categoryformdb = _CategoryRepository.GetById(categreq.Id);
            categoryformdb.Name = categreq.Name;
            categoryformdb.Image = categreq.Image;

            if (ModelState.IsValid)
            {
                try
                {
                  
                    _CategoryRepository.Save();
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", "Something Went wrong Please Make Sure you set Everything right");
                }
            }

            return View("Edit", categreq);
        }


    }
}
