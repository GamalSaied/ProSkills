namespace ProSkills.Models.ClientSide
{
    //public class Course
    //{

    //public int Id { get; set; }

    //[MaxLength(20)]
    //[MinLength(2)]

    //[Remote("CheckName", "Course", ErrorMessage = "Name is already exist")]
    //public string Name { get; set; }

    //[Required]
    //[Range(50, 100)]
    //public float Degree { get; set; }

    //public float Mindegree { get; set; }

    //[Remote("Divby", "Course", ErrorMessage = "Hours should be divided by 3")]
    //public int hours { get; set; }

    //public List<CrsResult>? CrsResults { get; set; }



    public class Course
    {

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int Hours { get; set; }
        public int NumberOfStudents { get; set; }
        public List<Student>? Students { get; set; }
        public double TotalFilesSize { get; set; }          // Maximum Alloable DataSize for this Coruse in Gegabyte
        public int NumberOfExams { get; set; }
        public List<CExam>? Exams { get; set; }
        public int NumberOfTasks { get; set; }
        public List<CTask>? Tasks { get; set; }
        public int NumberOfVideos { get; set; }
        public List<CVideo>? Videos { get; set; }
        public string Location { get; set; }                // Location of the course
        public string GroupName { get; set; }               // Name of the course group or category
        public string? AdditionalNotes { get; set; }        // Any additional notes or comments

        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public string CreatedAt { get; set; }
        public bool IsDeleted { get; set; }

    }
}

