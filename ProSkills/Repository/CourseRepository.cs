using ProSkills.Interfaces;
using ProSkills.Models.ClientSide;

namespace ProSkills.Repository
{
    public class CourseRepository : IRepository<Course>
    {

        ITIContext context;

        // Constructor to initialize the context
        public CourseRepository(ITIContext _context)
        {
            context = _context;
        }

        // Retrieves all Data from the database
        public List<Course> GetAll() => context.Course.ToList();

        // Retrieves a Data by its ID
        public Course GetById(int id) => context.Course.FirstOrDefault(d => d.Id == id);

        // Checks if a Data with the given name exists
        public Course CheckName(string name) => context.Course.FirstOrDefault(e => e.Name.ToLower() == name.ToLower());

        // Inserts a new Data into the database
        public void Insert(Course obj) => context.Add(obj);

        // Updates Data in the database
        public void Update(Course obj) => context.Update(obj);

        // Delete Data from the database by its ID
        public void Delete(int id)
        {
            Course obj = GetById(id);
            if (obj != null)
            {
                context.Remove(obj);
            }
        }

        // Saves changes made to the database
        public void Save() => context.SaveChanges();

        // Get By Name
        public Course GetByName(string Name) => context.Course.FirstOrDefault(d => d.Name == Name);

    }
}

