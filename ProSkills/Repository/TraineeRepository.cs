using Microsoft.EntityFrameworkCore;
using ProSkills.Interfaces;
using ProSkills.Models.ClientSide;

namespace ProSkills.Repository;

public class TraineeRepository : ITraineeRepository
{
    ITIContext context;

    // Constructor to initialize the context
    public TraineeRepository(ITIContext _context)
    {
        context = _context;
    }

    // Retrieves all Data from the database
    public List<Trainee> GetAll()
    {
        return context.Trainee
                      .Include(t => t.Courses)
                      .ThenInclude(ct => ct.Course)
                      .ToList();
    }
    // Retrieves a Data by its ID
    public Trainee GetById(int id)
    {
        var trainees = context.Trainee
                      .Include(t => t.Courses)
                      .ThenInclude(ct => ct.Course)
                      .FirstOrDefault(t => t.Id == id);

        if (trainees == null)
        {
            throw new KeyNotFoundException("No trainees found.");
        }
        return trainees;
    }
    // Checks if a Data with the given name exists
    public Trainee CheckName(string name) => context.Trainee.FirstOrDefault(e => e.Name.ToLower() == name.ToLower());

    // Inserts a new Data into the database
    public void Insert(Trainee obj)
    {
        if (obj == null)
        {
            throw new ArgumentNullException(nameof(obj), "Trainee cannot be null.");
        }

        context.Add(obj);
    }
    // Updates Data in the database
    public void Update(Trainee obj)
    {
        if (obj == null)
        {
            throw new ArgumentNullException(nameof(obj), "Trainee cannot be null.");
        }

        context.Update(obj);
    }
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
    public void MarkAsDeleted(int id)
    {
        throw new NotImplementedException();
    }

    public Trainee GetTraineeByEmail(string email)
    {
        // Your logic to retrieve the trainee by email
        return context.Trainee.FirstOrDefault(t => t.Email == email);
    }

}
