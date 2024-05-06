using ProSkills.Interfaces;
using ProSkills.Models.ClientSide;

namespace ProSkills.Repository
{
    public class CourseRepository:ICourseRepository
    {


        ITIContext context;
        public CourseRepository(ITIContext _context)
        {
            context = _context;
            //context = new ITIContext();
        }
        public List<Course> Getall()
        {
            return context.Course.ToList();
        }

        public Course GetById(int id)
        {
            return context.Course.FirstOrDefault(d => d.Id == id);
        }
     
        public Course checkName(string name)
        {

            return context.Course.FirstOrDefault(e => e.Name.ToLower() == name.ToLower());

        }

        public void Insert(Course obj)
        {
            context.Add(obj);
        }
        public void Update(Course obj)
        {
            context.Update(obj);
        }

        public void Delete(int id)
        {
            Course obj = GetById(id);
            if (obj != null)
            {
                context.Remove(obj);
            }
        }


        public void Save()
        {
            context.SaveChanges();
        }


    }
}

