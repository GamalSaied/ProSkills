using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProSkills.Models
{
    public class Course
    {

        public int Id { get; set; }

        [MaxLength(20)]
        [MinLength(2)]
    
        [Remote("CheckName", "Course", ErrorMessage = "Name is already exist")]
        public string Name { get; set; }

        [Required]
        [Range(50, 100)]
        public float Degree { get; set; }

        public float Mindegree { get; set; }

        [Remote("Divby", "Course", ErrorMessage = "Hours should be divided by 3")]
        public int hours { get; set; }

        public List<CrsResult>? CrsResults { get; set; }
    }
}
