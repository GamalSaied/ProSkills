using ProSkills.Models.ClientSide.Enumerators;

public class LeaderboardViewModel
{
    public int Rank { get; set; }
    public string ProfilePictureUrl { get; set; }
    public string FullName { get; set; }
    public Level Level { get; set; }
    public int Points { get; set; }
        public int CompletionPercentage { get; set; }  // Add this property

}
