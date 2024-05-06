using ProSkills.Interfaces;
using ProSkills.Models.ClientSide;

namespace ProSkills.Repository
{
    public class TraineeRepository :ITraineeRepository
    {
        ITIContext context;
        public TraineeRepository(ITIContext _context)
        {
            context = _context;

            //context = new ITIContext();
        }
        public List<Trainee> Getall()
        {
            return context.Trainee.ToList();
        }

        public Trainee GetbyId(int id)
        {
            return context.Trainee.FirstOrDefault(d => d.Id == id);
        }

        public void Insert(Trainee obj)
        {
            context.Add(obj);
        }
        public void Update(Trainee obj)
        {
            context.Update(obj);
        }

        public void Delete(int id)
        {
            Trainee obj = GetbyId(id);
            if (obj != null)
            {
                context.Remove(obj);
            }
        }


        public void Save()
        {
            context.SaveChanges();
        }
    }
}
