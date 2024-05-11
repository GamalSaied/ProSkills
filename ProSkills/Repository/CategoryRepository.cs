using ProSkills.Interfaces;
using ProSkills.Models.ClientSide;

namespace ProSkills.Repository
{
    public class CategoryRepository : IRepository<Category>
    {
        ITIContext context;

        // Constructor to initialize the context
        public CategoryRepository(ITIContext _context)
        {
            context = _context;
        }
        // Retrieves all Data from the database
        public List<Category> GetAll() => context.Category.ToList();

        // Retrieves a Data by its ID
        public Category GetById(int id) => context.Category.FirstOrDefault(d => d.Id == id);

        // Checks if a Data with the given name exists
        public Category CheckName(string name) => context.Category.FirstOrDefault(e => e.Name.ToLower() == name.ToLower());

        // Inserts a new Data into the database
        public void Insert(Category obj) => context.Add(obj);

        // Updates Data in the database
        public void Update(Category obj) => context.Update(obj);

        // Delete Data from the database by its ID
        public void Delete(int id)
        {
            Category obj = GetById(id);
            if (obj != null)
            {
                context.Remove(obj);
            }
        }

        // Saves changes made to the database
        public void Save() => context.SaveChanges();

        public Category GetByName(string Name) => context.Category.FirstOrDefault(d => d.Name == Name);
    }
        
   
}
