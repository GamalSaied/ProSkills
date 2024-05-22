using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProSkills.Models.ClientSide
{
    public class Lesson
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public string? downloadLink { get; set; }
        public string? TaskLink { get; set; }
        public TimeSpan? Time { get; set; } 
        public string? Content { get; set; }

        [ForeignKey("Chapter")]
        public int ChapterId { get; set; }
        public Chapter Chapter { get; set; }
    }
}
