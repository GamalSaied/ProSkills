﻿using ProSkills.Models.ClientSide;

namespace ProSkills.Interfaces
{
    public interface ICourseTraineeRepository : IRepository<CourseTrainee>
    {
        List<LeaderboardViewModel> GetLeaderboardByCourse(int courseId);
        CourseTrainee GetByUserEmailAndCourse(string email, int courseId);
    }

}
