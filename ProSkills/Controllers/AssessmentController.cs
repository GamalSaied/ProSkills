using Microsoft.AspNetCore.Mvc;
using ProSkills.Interfaces;
using ProSkills.Models.ClientSide;
using System;
using System.Linq;

namespace ProSkills.Controllers
{
    public class AssessmentController : Controller
    {
        private readonly IRepository<Assessment> _assessmentRepository;

        public AssessmentController(IRepository<Assessment> assessmentRepository)
        {
            _assessmentRepository = assessmentRepository;
        }

        // GET: Assessment
        public IActionResult Index()
        {
            var assessments = _assessmentRepository.GetAll().Where(a => !a.IsDeleted).ToList();
            return View(assessments);
        }

        // GET: Assessment/Details/5
        public IActionResult Details(int id)
        {
            var assessment = _assessmentRepository.GetById(id);
            if (assessment == null || assessment.IsDeleted)
            {
                return NotFound();
            }
            return View(assessment);
        }

        // GET: Assessment/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Assessment/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Assessment assessment)
        {
            if (ModelState.IsValid)
            {
                assessment.CreatedAt = DateTime.Now;
                assessment.UpdatedAt = DateTime.Now;
                _assessmentRepository.Insert(assessment);
                _assessmentRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(assessment);
        }

        // GET: Assessment/Edit/5
        public IActionResult Edit(int id)
        {
            var assessment = _assessmentRepository.GetById(id);
            if (assessment == null || assessment.IsDeleted)
            {
                return NotFound();
            }
            return View(assessment);
        }

        // POST: Assessment/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Assessment assessment)
        {
            if (ModelState.IsValid)
            {
                var existingAssessment = _assessmentRepository.GetById(assessment.Id);
                if (existingAssessment == null || existingAssessment.IsDeleted)
                {
                    return NotFound();
                }

                existingAssessment.Title = assessment.Title;
                existingAssessment.Description = assessment.Description;
                existingAssessment.Points = assessment.Points;
                existingAssessment.UpdatedAt = DateTime.Now;

                _assessmentRepository.Update(existingAssessment);
                _assessmentRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(assessment);
        }

        // GET: Assessment/Delete/5
        public IActionResult Delete(int id)
        {
            var assessment = _assessmentRepository.GetById(id);
            if (assessment == null || assessment.IsDeleted)
            {
                return NotFound();
            }
            return View(assessment);
        }

        // POST: Assessment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var assessment = _assessmentRepository.GetById(id);
            if (assessment == null)
            {
                return NotFound();
            }

            assessment.IsDeleted = true;
            _assessmentRepository.Update(assessment);
            _assessmentRepository.Save();

            return RedirectToAction(nameof(Index));
        }
    }
}
