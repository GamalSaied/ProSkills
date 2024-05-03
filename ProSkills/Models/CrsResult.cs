﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ProSkills.Models
{
    public class CrsResult
    {
        public int Id { get; set; }

        public float Degree { get; set; }


        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }

        [ForeignKey("Trainee")]
        public int TraineeId { get; set; }
        public Trainee Trainee { get; set; }
    }
}
