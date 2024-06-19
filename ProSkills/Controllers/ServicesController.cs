using Microsoft.AspNetCore.Mvc;
using ProSkills.Interfaces;
using ProSkills.Models.ClientSide;
using ProSkills.Repository;
using ProSkills.ViewModels;
using System;
using System.Linq;

namespace ProSkills.Controllers
{
    public class ServicesController : Controller
    {
        private readonly IRepository<Service> _serviceRepository;
        private readonly IWebHostEnvironment _environment;  // for img 

        public ServicesController(IRepository<Service> serviceRepository, IWebHostEnvironment environment)
        {
            _serviceRepository = serviceRepository;
            _environment = environment; // for img and constractor

        }

        public IActionResult Index()
        {
            var services = _serviceRepository.GetAll();
            var serviceViewModels = services.Select(service => new ServiceViewModel
            {
                Id = service.Id,
                Name = service.Name,
                Description = service.Description,
                Price = service.Price,
                ImageUrl = service.ImageUrl,
                InstructorName = service.InstructorName,
                Duration = service.Duration,
                Rating = service.Rating,
                ReviewCount = service.ReviewCount
            }).ToList();

            if (!serviceViewModels.Any())
            {
                return View("NoServices");
            }

            return View(serviceViewModels);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new ServiceViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Create(ServiceViewModel serviceViewModel, IFormFile Image)
        {
            if (ModelState.IsValid)
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

                    serviceViewModel.ImageUrl = "/images/" + uniqueFileName; // save the relative file path to the model
                }

                var service = new Service
                {
                    Name = serviceViewModel.Name,
                    Description = serviceViewModel.Description,
                    Price = serviceViewModel.Price,
                    ImageUrl = serviceViewModel.ImageUrl,
                    InstructorName = serviceViewModel.InstructorName,
                    Duration = serviceViewModel.Duration,
                    Rating = serviceViewModel.Rating,
                    ReviewCount = serviceViewModel.ReviewCount,
                    CreatedAt = DateTime.Now.ToString(),
                    IsDeleted = false
                };

                _serviceRepository.Insert(service);
                _serviceRepository.Save();

                return RedirectToAction("Index", "Services");
            }

            return View(serviceViewModel);
        }

        public IActionResult Edit(int id)
        {
            var service = _serviceRepository.GetById(id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }

        [HttpPost]
        public IActionResult Edit(Service service)
        {
            if (ModelState.IsValid)
            {
                _serviceRepository.Update(service);
                _serviceRepository.Save();
                return RedirectToAction(nameof(Index));
            }

            return View(service);
        }

        public IActionResult Delete(int id)
        {
            var service = _serviceRepository.GetById(id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _serviceRepository.Delete(id);
            _serviceRepository.Save();
            return RedirectToAction(nameof(Index));
        }
    }
}
