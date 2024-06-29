namespace ProSkills.ViewModels
{
    internal class AssessmentsInCourseViewModel
    {
        public int CourseId { get; set; }
        public string CourseTitle { get; set; }
        public List<AssessmentViewModel> Assessments { get; set; }
    }
}