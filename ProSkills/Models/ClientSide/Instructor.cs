namespace ProSkills.Models.ClientSide
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Speciallization { get; set; }
        public string Bio {  get; set; }

        #region ForeignKeys
        public ICollection<InstructorCourse> instructorCourses { get; set; }
        public ICollection<Module> modules { get; set; } 

        #endregion


    }
}
