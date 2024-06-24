namespace ProSkills.ViewModels
{
    internal class CoursesByCategoryViewModel
    {
        public List<CourseViewModel> EnrolledCourses { get; set; }
        public List<CourseViewModel> OtherCourses { get; set; }
        public string CategoryName { get; set; }
    public string CategoryDescription { get; set; }

    }
}