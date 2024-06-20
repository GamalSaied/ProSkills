namespace ProSkills.ViewModels
{
    public class PagedLeaderboardViewModel
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public List<LeaderboardViewModel> Leaderboard { get; set; }
    }

}