namespace ProSkills.ViewModels
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string InstructorName { get; set; }
        public double Duration { get; set; } // Duration in hours
        public int StudentCount { get; set; }
        public int Rating { get; set; } // Average ratinokg
        public int ReviewCount { get; set; } // Number of reviews
    }

}
