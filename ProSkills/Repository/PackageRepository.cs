using Microsoft.AspNetCore.Http.HttpResults;
using ProSkills.Interfaces;
using ProSkills.Models.AdminPanel.InstructorManger;
using ProSkills.Models.ClientSide;

namespace ProSkills.Repository
{
    public class PackageRepository : IRepository<Package>
    {
        ITIContext context;

        // Constructor to initialize the context
        public PackageRepository(ITIContext _context)
        {
            context = _context;
        }
        // Retrieves all Data from the database
        public List<Package> GetAll() => context.Package.ToList();

        // Retrieves a Data by its ID
        public Package GetById(int id) => context.Package.FirstOrDefault(d => d.Id == id);

        // Checks if a Data with the given name exists
        public Package CheckName(string name) => context.Package.FirstOrDefault(e => e.Name.ToLower() == name.ToLower());

        // Inserts a new Data into the database
        public void Insert(Package obj) => context.Add(obj);

        // Updates Data in the database
        public void Update(Package obj) => context.Update(obj);

        // Delete Data from the database by its ID
        public void Delete(int id)
        {
            Package obj = GetById(id);
            if (obj != null)
            {
                context.Remove(obj);
            }
        }

        // Saves changes made to the database
        public void Save() => context.SaveChanges();

        public Package GetByName(string Name) => context.Package.FirstOrDefault(d => d.Name == Name);
    }
}
