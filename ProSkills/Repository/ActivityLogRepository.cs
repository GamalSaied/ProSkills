using ProSkills.Interfaces;
using ProSkills.Models.ClientSide;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ProSkills.Repositories
{
    public class ActivityLogRepository : IActivityLogRepository
    {
        private readonly ITIContext context;

        public ActivityLogRepository(ITIContext _context)
        {
            context = _context;
        }

        public List<ActivityLog> GetAll()
        {
            return context.ActivityLogs.ToList();
        }

        public ActivityLog GetById(int id)
        {
            return context.ActivityLogs
                          .Include(a => a.Lesson)
                          .ThenInclude(l => l.Chapter)
                          .FirstOrDefault(a => a.Id == id);
        }

        public ActivityLog GetByName(string name)
        {
            // Implement if needed, otherwise return null or throw an exception
            return null;
        }

        public ActivityLog CheckName(string name)
        {
            // Implement if needed, otherwise return null or throw an exception
            return null;
        }

        public void Insert(ActivityLog obj)
        {
            context.ActivityLogs.Add(obj);
        }

        public void Update(ActivityLog obj)
        {
            context.ActivityLogs.Update(obj);
        }

        public void Delete(int id)
        {
            var activityLog = GetById(id);
            if (activityLog != null)
            {
                context.ActivityLogs.Remove(activityLog);
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void MarkAsDeleted(int id)
        {
            var activityLog = GetById(id);
            if (activityLog != null)
            {
                activityLog.IsDeleted = true;
                Update(activityLog);
                Save();
            }
        }
        public List<ActivityLog> GetByUserIdAndCourseId(string userId, int courseId)
        {
            return context.ActivityLogs
                .Include(a => a.Lesson)
                .ThenInclude(l => l.Chapter)
                .Where(a => a.UserId == userId && a.Lesson.Chapter.CourseId == courseId && a.ActivityType == "LessonCompleted" && !a.IsDeleted)
                .ToList();
        }


        public ActivityLog GetByUserIdAndLessonId(string userId, int lessonId)
        {
            return context.ActivityLogs
                .FirstOrDefault(a => a.UserId == userId && a.LessonId == lessonId && a.ActivityType == "LessonCompleted");
        }



    }
}
