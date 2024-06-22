using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using ProSkills.Interfaces;
using ProSkills.Models.ClientSide;
using ProSkills.Repository;
using System;

namespace ProSkills.Controllers
{
    public class CategoryController : Controller
    {
        private IRepository<Category> _CategoryRepository;
        private readonly IWebHostEnvironment _environment;  // for img 

        public CategoryController(IRepository<Category> CategoryRepository, IWebHostEnvironment environment)
        {
            _CategoryRepository = CategoryRepository;
            _environment = environment; // for img and constractor
        }
        public IActionResult Index()
        {

            List<Category> Categories = _CategoryRepository.GetAll();
            return View("Index", Categories);

        }


        //press submit button
        //Instructor/SaveNEw?Name=SD&ManagerName=Ahmed
        //action saveNew
        [HttpGet]

        public IActionResult New()
        {
            return View("New");
        }

        [HttpPost]//action attribute
        public async Task<IActionResult> SaveNew(Category CategoryFromReq, IFormFile Image)
        {
            if (CategoryFromReq.Name != null)
            {



                if (Image != null && Image.Length > 0)
                {
                    string uploadsFolder = Path.Combine(_environment.WebRootPath, "images");
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(Image.FileName);
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await Image.CopyToAsync(fileStream);
                    }

                    CategoryFromReq.Image = uniqueFileName; // save the filename to the model
                }

                CategoryFromReq.CreatedAt = "Created At " + DateTime.Now;
                _CategoryRepository.Insert(CategoryFromReq);
                _CategoryRepository.Save();

                return RedirectToAction("Index", "Category");
            }

            return View("New", CategoryFromReq);
        }

        [HttpGet]//action attribute
        public IActionResult Edit(int id)
        {
            //Get data           
            var Category = _CategoryRepository.GetById(id);
            return View("Edit", Category);
        }

        [HttpPost]//action attribute
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

        //public async Task<IActionResult> SaveNew(Instractor instractorFromReq, string Department, string Course, IFormFile img)
        //{
        //    // Get The Department ID
        //    int DeptID = context.Department.FirstOrDefault(item => item.Name == Department)?.ID ?? 0;

        //    // Get Course ID
        //    int CourseID = context.Course.FirstOrDefault(item => item.Name == Course)?.ID ?? 0;

        //    if (img != null && img.Length > 0)
        //    {
        //        string uploadsFolder = Path.Combine(_environment.WebRootPath, "images");
        //        string uniqueFileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(img.FileName);
        //        string filePath = Path.Combine(uploadsFolder, uniqueFileName);

        //        using (var fileStream = new FileStream(filePath, FileMode.Create))
        //        {
        //            await img.CopyToAsync(fileStream);
        //        }

        //        instractorFromReq.img = uniqueFileName; // save the filename to the model
        //    }

        //    if (!string.IsNullOrEmpty(instractorFromReq.Name))
        //    {
        //        instractorFromReq.DepartmentId = DeptID;
        //        instractorFromReq.CourseId = CourseID;
        //        instractorFromReq.CreatedAt = await OnlineDateHelper.GetOnlineDateTime();
        //        context.Add(instractorFromReq);


        //        // Add Activitylog Database
        //        ActivityLog Mylog = new ActivityLog();
        //        Mylog.Selected_ID = instractorFromReq.ID;
        //        Mylog.Selected_Name = instractorFromReq.Name;
        //        Mylog.Admin = "Sadat";
        //        Mylog.role = "New ";
        //        Mylog.CreatedAt = "Added At " + await OnlineDateHelper.GetOnlineDateTime();
        //        Mylog.Activity = $"Name: {instractorFromReq.Name}";
        //        context.Add(Mylog);
        //        //-------------------------------------------------------------------------

        //        await context.SaveChangesAsync();
        //        return RedirectToAction("ShowAll", "Instractor"); // return to Showall Page
        //    }

        //    return View("AddNew", instractorFromReq); // return to AddNew View with the same model
        //}

    }
}
