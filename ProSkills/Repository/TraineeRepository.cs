using Microsoft.EntityFrameworkCore;
using ProSkills.Interfaces;
using ProSkills.Models.ClientSide;

namespace ProSkills.Repository
{
    public class TraineeRepository : ITraineeRepository
    {
        private readonly ITIContext context;

        public TraineeRepository(ITIContext _context)
        {
            context = _context;
        }

        public List<Trainee> GetAll()
        {
            return context.Trainee
                          .Include(t => t.Courses)
                          .ThenInclude(ct => ct.Course)
                          .ToList();
        }

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

        public Trainee CheckName(string name) => context.Trainee.FirstOrDefault(e => e.Name.ToLower() == name.ToLower());

        public void Insert(Trainee obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "Trainee cannot be null.");
            }

            context.Add(obj);
        }

        public void Update(Trainee obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "Trainee cannot be null.");
            }

            context.Update(obj);
        }

        public void Delete(int id)
        {
            Trainee obj = GetById(id);
            if (obj != null)
            {
                context.Remove(obj);
            }
        }

        public void Save() => context.SaveChanges();

        public Trainee GetByName(string Name) => context.Trainee.FirstOrDefault(d => d.Name == Name);

        public void MarkAsDeleted(int id)
        {
            throw new NotImplementedException();
        }

        public Trainee GetTraineeByEmail(string email)
        {
            return context.Trainee.FirstOrDefault(t => t.Email == email);
        }
    }
}
