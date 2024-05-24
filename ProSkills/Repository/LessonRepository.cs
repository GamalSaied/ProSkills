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
            return context.Lessons.ToList();
        }

        public Lesson GetById(int id)
        {
            return context.Lessons.FirstOrDefault(l => l.Id == id);
        }

        public Lesson GetByName(string name)
        {
            return context.Lessons.FirstOrDefault(l => l.Title == name);
        }

        public Lesson CheckName(string name)
        {
            return context.Lessons.FirstOrDefault(l => l.Title.ToLower() == name.ToLower());
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
    }
}
