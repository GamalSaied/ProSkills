using ProSkills.Interfaces;
using ProSkills.Models.ClientSide;
using System.Collections.Generic;
using System.Linq;

namespace ProSkills.Repositories
{
    public class AssessmentRepository : IRepository<Assessment>
    {
        private readonly ITIContext _context;

        public AssessmentRepository(ITIContext context)
        {
            _context = context;
        }

        public List<Assessment> GetAll()
        {
            return _context.Assessments.ToList();
        }

        public Assessment GetById(int id)
        {
            return _context.Assessments.Find(id);
        }

        public Assessment GetByName(string name)
        {
            return _context.Assessments.FirstOrDefault(a => a.Title == name);
        }

        public Assessment CheckName(string name)
        {
            return _context.Assessments.FirstOrDefault(a => a.Title == name);
        }

        public void Insert(Assessment entity)
        {
            _context.Assessments.Add(entity);
        }

        public void Update(Assessment entity)
        {
            _context.Assessments.Update(entity);
        }

        public void Delete(int id)
        {
            var assessment = _context.Assessments.Find(id);
            if (assessment != null)
            {
                _context.Assessments.Remove(assessment);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void MarkAsDeleted(int id)
        {
            var assessment = _context.Assessments.Find(id);
            if (assessment != null)
            {
                assessment.IsDeleted = true; // Assuming there is an IsDeleted property in the Assessment class
                _context.Assessments.Update(assessment);
            }
        }
    }
}
