using ProSkills.Models.ClientSide;

namespace ProSkills.Interfaces
{
    public interface ICourseRepository
    {
        List<Course> Getall();
        Course GetById(int id);

        Course checkName(string name);
        void Insert(Course obj);
        void Update(Course obj);
        void Delete(int id);
        void Save();
    }
}
