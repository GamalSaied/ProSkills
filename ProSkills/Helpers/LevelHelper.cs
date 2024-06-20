using ProSkills.Models.ClientSide.Enumerators;

namespace ProSkills.Helpers
{
    public static class LevelHelper
    {
        public static Level DetermineLevel(int points)
        {
            if (points >= 0 && points < 50)
                return Level.Beginner;
            else if (points >= 50 && points < 200)
                return Level.Amature;
            else if (points >= 200 && points < 400)
                return Level.Semi_Pro;
            else if (points >= 400 && points < 700)
                return Level.Professional;
            else
                return Level.Legendary;
        }


    }

}
