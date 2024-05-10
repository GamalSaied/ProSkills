using Microsoft.AspNetCore.Mvc;
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
        [HttpPost]//action attribute
        public ActionResult Delete(int id)
        {
         
            var Category = _CategoryRepository.GetById(id);
            if (Category == null)
            {
                return NotFound();
            }


            _CategoryRepository.Delete(id);
            _CategoryRepository.Save();
          
            return RedirectToAction("Index"); // Redirect to the list of Categories after deletion
        }


        [HttpGet]
        public IActionResult New()
        {
        
            return View("New");
        }

        //press submit button
        //Instructor/SaveNEw?Name=SD&ManagerName=Ahmed
        //action saveNew

        [HttpPost]//action attribute
        public IActionResult SaveNew(Category categreq)
        {
            if (categreq.Name != null)
            {
                _CategoryRepository.Insert(categreq);
                _CategoryRepository.Save();
               
                return RedirectToAction("Index", "Category");
            }

            return View("New", categreq);
        }


        public IActionResult Edit(int id)
        {
            //Get data
            
            var Category = _CategoryRepository.GetById(id);

            return View("Edit", Category);//load old info


        }


        //Saveedit for the instructor
        public IActionResult SaveEdit(Category categreq)
        {
            if (categreq.Name != null)
            {
        
                var CategfromDb = _CategoryRepository.GetById(categreq.Id);
               
                _CategoryRepository.Update(CategfromDb);
                
                _CategoryRepository.Save();
                
                return RedirectToAction("Index");
            }
            
            return View("Edit", categreq);
        }


    }
}
