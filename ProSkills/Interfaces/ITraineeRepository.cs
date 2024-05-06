using ProSkills.Models.ClientSide;

namespace ProSkills.Interfaces
{
    public interface ITraineeRepository
    {
        List<Trainee> Getall();

        Trainee GetbyId(int id);
        void Insert(Trainee obj);
        void Update(Trainee obj);
        void Delete(int id);
        void Save();
    }
}
