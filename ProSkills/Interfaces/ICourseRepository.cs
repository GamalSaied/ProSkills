using ProSkills.Models.ClientSide;

namespace ProSkills.Interfaces
{
    // Repositories/ICourseRepository.cs
    public interface ICourseRepository
    {
        IEnumerable<Course> GetAllCoursesWithDetails();
        Course GetCourseWithDetails(int CourseId);

        List<Course> GetCourseTraineeWithDetails(int CourseId);
    }
}
