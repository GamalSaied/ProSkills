using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProSkills.Models.ClientSide
{
    public class Chapter
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string? Description { get; set; }

        public string? downloadLink { get; set; }


        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course? Course { get; set; }

        public List<Lesson> Lessons { get; set; } = new List<Lesson>();

        [NotMapped]
        public TimeSpan TotalTime
        {
            get
            {
                return Lessons?.Aggregate(TimeSpan.Zero, (sum, lesson) => sum.Add((TimeSpan)lesson.Time)) ?? TimeSpan.Zero;
            }
        }
    }
}
