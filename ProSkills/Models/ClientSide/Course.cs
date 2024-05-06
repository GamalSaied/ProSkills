namespace ProSkills.Models.ClientSide
{
    public class Course
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Hours { get; set; }
        //public int NumberOfStudents { get; set; }
        //public List<Student>? Students { get; set; }
        //public double TotalFilesSize { get; set; }          // Maximum Alloable DataSize for this Coruse in Gegabyte
        //public int NumberOfExams { get; set; }
        ////public List<CExam>? Exams { get; set; }
        //public int NumberOfTasks { get; set; }
        //public List<CTask>? Tasks { get; set; }
        //public int NumberOfVideos { get; set; }
        //public List<CVideo>? Videos { get; set; }
        //public string? Location { get; set; }               // Location of the course
        //public string GroupName { get; set; }               // Name of the course group or category
        //public string? AdditionalNotes { get; set; }        // Any additional notes or comments

        //public DateTime StartAt { get; set; }
        //public DateTime EndAt { get; set; }
        //public string CreatedAt { get; set; }
        //public bool IsDeleted { get; set; }

        //// Forigen Key but not written 
        //public int InstractorID { get; set; }            // Every Course Must Created by instractor // Must be Required 
        public List<Trainee>? Trainees { get; set; }


    }
}

