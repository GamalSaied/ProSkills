using System.ComponentModel.DataAnnotations;

namespace ProSkills.Models.ClientSide
{
    public class Package
    {
        [Key]    
        public int Id { get; set; }
        public string Name { get; set; }
       
        public string Image { get; set; }

        public int Hours { get; set; }
        public int NumberOfTrainees { get; set; }
        public int NumberOfAssesments { get; set; }
        public int NumberOfLessons { get; set; }
        public double TotlaFileSize { get; set; }


        public bool? IsDeleted { get; set; } = false;
    }
}
