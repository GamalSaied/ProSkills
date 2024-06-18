using ProSkills.Models.ClientSide;

namespace ProSkills.Interfaces
{
    public interface ITraineeRepository : IRepository<Trainee>
    {
        
            Trainee GetTraineeByEmail(string email);
        
    }
}
