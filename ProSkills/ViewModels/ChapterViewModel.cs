namespace ProSkills.ViewModels
{
    public class ChapterViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<LessonViewModel> Lessons { get; set; }
    }
}