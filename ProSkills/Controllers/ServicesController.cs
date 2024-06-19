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
            var services = _serviceRepository.GetAll().Where(s => !s.IsDeleted);
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

            var serviceViewModel = new ServiceViewModel
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
            };

            return View(serviceViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ServiceViewModel serviceViewModel, IFormFile image)
        {
            if (id != serviceViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var service = _serviceRepository.GetById(id);
                    if (service == null)
                    {
                        return NotFound();
                    }

                    if (image != null && image.Length > 0)
                    {
                        string uploadsFolder = Path.Combine(_environment.WebRootPath, "images");
                        string uniqueFileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(image.FileName);
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await image.CopyToAsync(fileStream);
                        }

                        service.ImageUrl = "/images/" + uniqueFileName; // Update the image URL
                    }

                    service.Name = serviceViewModel.Name;
                    service.Description = serviceViewModel.Description;
                    service.Price = serviceViewModel.Price;
                    service.InstructorName = serviceViewModel.InstructorName;
                    service.Duration = serviceViewModel.Duration;
                    service.Rating = serviceViewModel.Rating;
                    service.ReviewCount = serviceViewModel.ReviewCount;

                    _serviceRepository.Update(service);
                    _serviceRepository.Save();

                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
                }
            }

            return View(serviceViewModel);
        }
        public IActionResult Delete(int id)
        {
            var service = _serviceRepository.GetById(id);
            if (service == null)
            {
                return NotFound();
            }

            var serviceViewModel = new ServiceViewModel
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
            };

            return View(serviceViewModel);
        }

        [HttpPost]
        public IActionResult SoftDelete(int id)
        {
            var service = _serviceRepository.GetById(id);
            if (service != null)
            {
                service.IsDeleted = true;
                _serviceRepository.Update(service);
                _serviceRepository.Save();
            }
            return RedirectToAction(nameof(Index));
        }

    }
}
