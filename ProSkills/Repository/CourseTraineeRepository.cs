using Microsoft.EntityFrameworkCore;
using ProSkills.Helpers;
using ProSkills.Interfaces;
using ProSkills.Models.ClientSide;

namespace ProSkills.Repository
{
    public class CourseTraineeRepository : ICourseTraineeRepository
    {
        private readonly ITIContext context;

        public CourseTraineeRepository(ITIContext _context)
        {
            context = _context;
        }

        public List<CourseTrainee> GetAll() => context.CourseTrainee.ToList();

        public CourseTrainee GetById(int id) => context.CourseTrainee.FirstOrDefault(ct => ct.Id == id);

        public void Insert(CourseTrainee obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "CourseTrainee cannot be null.");
            }

            context.Add(obj);
        }

        public void Update(CourseTrainee obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "CourseTrainee cannot be null.");
            }

            context.Update(obj);
        }

        public void Delete(int id)
        {
            var obj = GetById(id);
            if (obj != null)
            {
                context.Remove(obj);
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public CourseTrainee GetByName(string id)
        {
            throw new NotImplementedException();
        }

        public CourseTrainee CheckName(string name)
        {
            throw new NotImplementedException();
        }

        public void MarkAsDeleted(int id)
        {
            throw new NotImplementedException();
        }

        public List<LeaderboardViewModel> GetLeaderboardByCourse(int courseId)
        {
            var courseTrainees = context.CourseTrainee
                .Where(ct => ct.CourseId == courseId)
                .Include(ct => ct.Trainee)
                .ToList(); // Fetch data from the database

            var leaderboard = courseTrainees
                .OrderByDescending(ct => ct.Points)
                .Select((ct, index) => new LeaderboardViewModel
                {
                    Rank = index + 1,
                    ProfilePictureUrl = ct.Trainee.ProfilePictureUrl,
                    FullName = ct.Trainee.Name,
                    Level = LevelHelper.DetermineLevel(ct.Points), // Determine level based on points
                    Points = ct.Points
                })
                .ToList(); // Transform data in memory

            return leaderboard;
        }


    }

}
