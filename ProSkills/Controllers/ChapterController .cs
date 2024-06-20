using Microsoft.AspNetCore.Mvc;
using ProSkills.Interfaces;
using ProSkills.Models.ClientSide;

namespace ProSkills.Controllers
{
    public class ChapterController : Controller
    {
        private readonly IRepository<Chapter> _chapterRepository;

        public ChapterController(IRepository<Chapter> chapterRepository)
        {
            _chapterRepository = chapterRepository;
        }


        // GET: Chapter/AddNew
        [HttpGet]
        public IActionResult AddNew(int CourseId)
        {
            ViewBag.CourseId = CourseId;
            return View(new Chapter { CourseId = CourseId });
        }

        // POST: Chapter/AddNew
        [HttpPost]
        public IActionResult AddNew(Chapter chapter)
        {
            if (ModelState.IsValid)
            {
                _chapterRepository.Insert(chapter);
                _chapterRepository.Save();
                return RedirectToAction("ChaptersInCourse", "Course", new { CourseId = chapter.CourseId });
            }

            ViewBag.CourseId = chapter.CourseId;
            return View(chapter);
        }


        // GET: Chapter/Edit
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var chapter = _chapterRepository.GetById(id);
            if (chapter == null)
            {
                return NotFound();
            }

            return View(chapter);
        }

        // POST: Chapter/Edit
        [HttpPost]
        public IActionResult Edit(Chapter chapter)
        {
            if (ModelState.IsValid)
            {
                _chapterRepository.Update(chapter);
                _chapterRepository.Save();
                return RedirectToAction("ChaptersInCourse", "Course", new { CourseId = chapter.CourseId });
            }

            return View(chapter);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var chapter = _chapterRepository.GetById(id);
            if (chapter != null)
            {
                chapter.IsDeleted = true;
                _chapterRepository.Update(chapter);
                _chapterRepository.Save();
                return RedirectToAction("ChaptersInCourse", "Course", new { CourseId = chapter.CourseId });
            }
            return NotFound();
        }

    }
}
