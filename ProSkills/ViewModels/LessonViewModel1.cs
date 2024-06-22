namespace ProSkills.ViewModels
{
    public class LessonViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string DownloadLink { get; set; }
        public string TaskLink { get; set; }
        public TimeSpan Time { get; set; }
    }
}