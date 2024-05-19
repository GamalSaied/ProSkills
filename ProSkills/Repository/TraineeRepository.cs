using ProSkills.Interfaces;
using ProSkills.Models.ClientSide;

namespace ProSkills.Repository;

public class TraineeRepository : IRepository<Trainee>
{
    ITIContext context;

    // Constructor to initialize the context
    public TraineeRepository(ITIContext _context)
    {
        context = _context;
    }

    // Retrieves all Data from the database
    public List<Trainee> GetAll() => context.Trainee.ToList();

    // Retrieves a Data by its ID
    public Trainee GetById(int id) => context.Trainee.FirstOrDefault(d => d.Id == id);

    // Checks if a Data with the given name exists
    public Trainee CheckName(string name) => context.Trainee.FirstOrDefault(e => e.Name.ToLower() == name.ToLower());

    // Inserts a new Data into the database
    public void Insert(Trainee obj) => context.Add(obj);

    // Updates Data in the database
    public void Update(Trainee obj) => context.Update(obj);

    // Delete Data from the database by its ID
    public void Delete(int id)
    {
        Trainee obj = GetById(id);
        if (obj != null)
        {
            context.Remove(obj);
        }
    }

    // Saves changes made to the database
    public void Save() => context.SaveChanges();

    // Get By Name
    public Trainee GetByName(string Name) => context.Trainee.FirstOrDefault(d => d.Name == Name);


}
