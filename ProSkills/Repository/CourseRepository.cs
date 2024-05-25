using Microsoft.EntityFrameworkCore;
using ProSkills.Interfaces;
using ProSkills.Models.ClientSide;
using ProSkills.Models.ClientSide;
using System.Data.OleDb;

namespace ProSkills.Repository
{
    public class CourseRepository : IRepository<Course> , ICourseRepository
    {

        ITIContext context;

        // Constructor to initialize the context
        public CourseRepository(ITIContext _context)
        {
            context = _context;
        }

        // Retrieves all Data from the database
        public List<Course> GetAll()
        {
            var courses = context.Course
                                 .Include(c => c.Instructor)
                                 .Include(c => c.Trainees)
                                 .ThenInclude(ct => ct.Trainee)
                                 .ToList();

            if (courses == null || courses.Count == 0)
            {
                throw new KeyNotFoundException("No courses found.");
            }

            return courses;
        }
        // Retrieves a Data by its ID
        public Course GetById(int id)
        {
            var course = context.Course
                                .Include(c => c.Instructor)
                                .Include(c => c.Trainees)
                                .ThenInclude(ct => ct.Trainee)
                                .FirstOrDefault(d => d.Id == id);

            if (course == null)
            {
                throw new KeyNotFoundException($"Course with Id {id} not found.");
            }

            return course;
        }

        public Course GetByName(string name)
        {
            var course = context.Course.Include(c => c.Instructor)
                                .Include(c => c.Trainees)
                                .ThenInclude(ct => ct.Trainee)
                                .FirstOrDefault(d => d.Name == name);

            if (course == null)
            {
                throw new KeyNotFoundException($"Course with Name '{name}' not found.");
            }

            return course;
        }
        // Checks if a Data with the given name exists
        public Course CheckName(string name)
        {
            var course = context.Course.Include(c => c.Instructor)
                                .Include(c => c.Trainees)
                                .ThenInclude(ct => ct.Trainee)
                                .FirstOrDefault(e => e.Name.ToLower() == name.ToLower());

            if (course == null)
            {
                throw new KeyNotFoundException($"Course with Name '{name}' not found.");
            }

            return course;
        }

        // Inserts a new Data into the database
        public void Insert(Course obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "Course cannot be null.");
            }

            if (obj.Id == 0)
            {
                var lastCourse = context.Course.OrderByDescending(c => c.Id).FirstOrDefault();
                obj.Id = (lastCourse != null) ? lastCourse.Id + 1 : 1;
            }
            context.Add(obj);
        }
        // Updates Data in the database
        public void Update(Course obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "Course cannot be null.");
            }

            context.Update(obj);
        }
        // Delete Data from the database by its ID
        public void Delete(int id)
        {
            Course obj = GetById(id);
            if (obj != null)
            {
                context.Remove(obj);
            }
        }

        // Saves changes made to the database
        public void Save() => context.SaveChanges();

        public IEnumerable<Course> GetAllCoursesWithDetails()
        {
            return context.Course
                .Include(c => c.Chapters)
                .ThenInclude(ch => ch.Lessons)
                .ToList();
        }

        public Course GetCourseWithDetails(int courseId)
        {
            return context.Course
                .Include(c => c.Chapters)
                .ThenInclude(ch => ch.Lessons)
                .FirstOrDefault(c => c.Id == courseId);
        }
        public void MarkAsDeleted(int id)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetCourseTraineeWithDetails(int TraineeId)
        {
            // Mini to Mini Relationship
            var trainee = context.Trainee
                       .Include(t => t.Courses)
                       .ThenInclude(ct => ct.Course) // Assuming CourseTrainee has a property Course
                       .FirstOrDefault(t => t.Id == TraineeId);

            if (trainee == null)
            {
                // Return an empty list or handle the case when the trainee is not found
                return new List<Course>();
            }

            return trainee.Courses.Select(ct => ct.Course).ToList();
        }

    }
}

