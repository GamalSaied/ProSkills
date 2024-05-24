using ProSkills.Models.ClientSide;

namespace ProSkills.Interfaces
{
    // Repositories/ICourseRepository.cs
    public interface ICourseRepository
    {
        IEnumerable<Course> GetAllCoursesWithDetails();
        Course GetCourseWithDetails(int courseId);

        List<Course> GetCourseTraineeWithDetails(int courseId);
    }
}
