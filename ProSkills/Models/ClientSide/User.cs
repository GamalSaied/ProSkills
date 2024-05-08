using ProSkills.Models.ClientSide.Enumerators;

namespace ProSkills.Models.ClientSide
{
    public class User
    {
        //public string FirstName { get; set; } = string.Empty;

        //public string LastName { get; set; } = string.Empty;

        public UserType UserType { get; set; }

        public Country Country { get; set; }

        public bool IsDeleted { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? ModifiedAt { get; set; }
      
       
    }
}
