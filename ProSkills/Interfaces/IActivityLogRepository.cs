using ProSkills.Models.ClientSide;
using System.Collections.Generic;

namespace ProSkills.Interfaces
{
    public interface IActivityLogRepository : IRepository<ActivityLog>
    {
        List<ActivityLog> GetByUserIdAndCourseId(string email, int courseId);

        ActivityLog GetByUserIdAndLessonId(string userId, int lessonId);


    }
}
