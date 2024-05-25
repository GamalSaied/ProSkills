using Microsoft.AspNetCore.Mvc;
using ProSkills.Interfaces;
using ProSkills.Models.ClientSide;
using System.Linq;

namespace ProSkills.Controllers
{
    public class LessonController : Controller
    {
        private readonly IRepository<Lesson> _lessonRepository;
        
        public LessonController(IRepository<Lesson> lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }

        [HttpGet]
        public IActionResult AddNew(int chapterId)
        {
            ViewBag.ChapterId = chapterId;
            return View(new Lesson { ChapterId = chapterId });
        }

        // POST: Lesson/AddNew
        [HttpPost]
        public IActionResult AddNew(Lesson lesson)
        {
            if (ModelState.IsValid)
            {
                _lessonRepository.Insert(lesson);
                _lessonRepository.Save();
                return RedirectToAction("LessonsInChapter", "Course", new { chapterId = lesson.ChapterId });
            }

            ViewBag.ChapterId = lesson.ChapterId;
            return View(lesson);
        }


        // GET: Lesson/Edit
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var lesson = _lessonRepository.GetById(id);
            if (lesson == null)
            {
                return NotFound();
            }

            return View(lesson);
        }

        // POST: Lesson/Edit
        [HttpPost]
        public IActionResult Edit(Lesson lesson)
        {

            _lessonRepository.Update(lesson);
            _lessonRepository.Save();
            return RedirectToAction("LessonsInChapter", "Course",new { chapterId = lesson.ChapterId });


            return View(lesson);
        }

        // POST: Lesson/Delete
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var lesson = _lessonRepository.GetById(id);
            if (lesson != null)
            {
                lesson.IsDeleted = true;
                _lessonRepository.Update(lesson);
                _lessonRepository.Save();
                return RedirectToAction("LessonsInChapter", "Course", new { chapterId = lesson.ChapterId });
            }
            return NotFound();
        }

    }
}
