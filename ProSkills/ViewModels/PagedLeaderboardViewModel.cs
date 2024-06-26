﻿namespace ProSkills.ViewModels
{
    public class PagedLeaderboardViewModel
    {
        public int CurrentPage { get; set; }
        public double PageSize { get; set; }
        public int TotalPages { get; set; }
        public List<LeaderboardViewModel> Leaderboard { get; set; }
        public LeaderboardViewModel CurrentUser { get; set; } // Add this property
    }


}