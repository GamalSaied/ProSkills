using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProSkills.Interfaces;
using ProSkills.Models.ClientSide;

namespace ProSkills.Repositories
{
    public class ChapterRepository : IRepository<Chapter>
    {
        private readonly ITIContext context;

        public ChapterRepository(ITIContext _context)
        {
            context = _context;
        }

        public List<Chapter> GetAll()
        {
            return context.Chapters.Include(c => c.Lessons).ToList();
        }

        public Chapter GetById(int id)
        {
            return context.Chapters.Include(c => c.Lessons).FirstOrDefault(c => c.Id == id);
        }

        public Chapter GetByName(string name)
        {
            return context.Chapters.Include(c => c.Lessons).FirstOrDefault(c => c.Title == name);
        }

        public Chapter CheckName(string name)
        {
            return context.Chapters.Include(c => c.Lessons).FirstOrDefault(c => c.Title.ToLower() == name.ToLower());
        }


        public void Insert(Chapter obj)
        {
            context.Chapters.Add(obj);

        }

        public void Update(Chapter obj)
        {
            context.Chapters.Update(obj);
        }

        public void Delete(int id)
        {
            var chapter = GetById(id);
            if (chapter != null)
            {
                context.Chapters.Remove(chapter);
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }
        public void MarkAsDeleted(int id)
        {
            var chapter = GetById(id);
            if (chapter != null)
            {
                chapter.IsDeleted = true;
                Update(chapter);
                Save();
            }
        }


    }
}
