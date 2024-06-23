namespace ProSkills.ViewModels
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string VendorName { get; set; }
        public double Duration { get; set; }
        public int StudentCount { get; set; }
        public int Rating { get; set; }
        public int ReviewCount { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public string Location { get; set; }
        public string ImagePath { get; set; } = "\\Images\\DefaultCourseImg.png";
        public List<ChapterViewModel> Chapters { get; set; } = new List<ChapterViewModel>();
        public List<AssessmentViewModel> Assessments { get; set; } = new List<AssessmentViewModel>();
        public double TotalFilesSize { get; set; } // Maximum allowable data size for this course in GB
        public int NumberOfAssessment { get; set; }
        public int NumberOfLessons { get; set; }
        public InstructorViewModel Instructor { get; set; }
        public double CompletionRatio { get; set; } // Add this line
        public bool IsEnrolled { get; set; } // Add this property

    }


}
