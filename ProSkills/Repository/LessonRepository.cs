using System;
using System.Collections.Generic;
using System.Linq;
using ProSkills.Interfaces;
using ProSkills.Models.ClientSide;

namespace ProSkills.Repositories
{
    public class LessonRepository : IRepository<Lesson>
    {
        private readonly ITIContext context;

        public LessonRepository(ITIContext _context)
        {
            context = _context;
        }

        public List<Lesson> GetAll()
        {
            return context.Lessons.Where(l => !l.IsDeleted).ToList();
        }

        public Lesson GetById(int id)
        {
            return context.Lessons.FirstOrDefault(l => l.Id == id && !l.IsDeleted);
        }

        public Lesson GetByName(string name)
        {
            return context.Lessons.FirstOrDefault(l => l.Title == name && !l.IsDeleted);
        }

        public Lesson CheckName(string name)
        {
            return context.Lessons.FirstOrDefault(l => l.Title.ToLower() == name.ToLower() && !l.IsDeleted);
        }

        public void Insert(Lesson obj)
        {
            context.Lessons.Add(obj);

        }

        public void Update(Lesson obj)
        {
            context.Lessons.Update(obj);
        }

        public void Delete(int id)
        {
            var lesson = GetById(id);
            if (lesson != null)
            {
                context.Lessons.Remove(lesson);
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void MarkAsDeleted(int id)
        {
            var lesson = GetById(id);
            if (lesson != null)
            {
                lesson.IsDeleted = true;
                Update(lesson);
                Save();
            }
        }
    }
}
