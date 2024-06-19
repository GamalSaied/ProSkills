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
                VendorName = service.VendorName,
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
                    VendorName = serviceViewModel.VendorName,
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
                VendorName = service.VendorName,
                Duration = service.Duration,
                Rating = service.Rating,
                ReviewCount = service.ReviewCount,
                Information = service.Information,
                DownloadLink = service.DownloadLink,
                DemoLink = service.DemoLink
            };

            return View(serviceViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ServiceViewModel serviceViewModel)
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

                    if (serviceViewModel.Image != null && serviceViewModel.Image.Length > 0)
                    {
                        string uploadsFolder = Path.Combine(_environment.WebRootPath, "images");
                        string uniqueFileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(serviceViewModel.Image.FileName);
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await serviceViewModel.Image.CopyToAsync(fileStream);
                        }

                        service.ImageUrl = "/images/" + uniqueFileName; // Update the image URL
                    }

                    service.Name = serviceViewModel.Name;
                    service.Description = serviceViewModel.Description;
                    service.Price = serviceViewModel.Price;
                    service.VendorName = serviceViewModel.VendorName;
                    service.Duration = serviceViewModel.Duration;
                    service.Rating = serviceViewModel.Rating;
                    service.ReviewCount = serviceViewModel.ReviewCount;
                    service.Information = serviceViewModel.Information;
                    service.DownloadLink = serviceViewModel.DownloadLink;
                    service.DemoLink = serviceViewModel.DemoLink;

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
                VendorName = service.VendorName,
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

        public IActionResult Details(int id)
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
                VendorName = service.VendorName,
                Duration = service.Duration,
                Rating = service.Rating,
                ReviewCount = service.ReviewCount,
                Information = service.Information,
                DownloadLink = service.DownloadLink,
                DemoLink = service.DemoLink
            };

            return View(serviceViewModel);
        }



    }
}
