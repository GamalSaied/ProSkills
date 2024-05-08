using Microsoft.CodeAnalysis.Operations;
using ProSkills.Interfaces;

using ProSkills.Models.AdminPanel.InstructorManger;
using ProSkills.Models.ClientSide;

namespace ProSkills.Repository
{
    public class InstructorRepository : IRepository<instructor>
    {
        ITIContext context;

        // Constructor to initialize the context
        public InstructorRepository(ITIContext _context)
        {
            context = _context;
        }

        // Retrieves all Data from the database
        public List<instructor> GetAll() => context.instructor.ToList();

        // Retrieves a Data by its ID
        public instructor GetById(int id) => context.instructor.FirstOrDefault(d => d.Id == id);

        // Checks if a Data with the given name exists
        public instructor CheckName(string name) => context.instructor.FirstOrDefault(e => e.Name.ToLower() == name.ToLower());

        // Inserts a new Data into the database
        public void Insert(instructor obj) => context.Add(obj);

        // Updates Data in the database
        public void Update(instructor obj) => context.Update(obj);

        // Delete Data from the database by its ID
        public void Delete(int id)
        {
            instructor obj = GetById(id);
            if (obj != null)
            {
                context.Remove(obj);
            }
        }

        // Saves changes made to the database
        public void Save() => context.SaveChanges();

      
    }
}
