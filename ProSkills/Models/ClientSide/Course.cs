﻿using Syncfusion.EJ2.Spreadsheet;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace ProSkills.Models.ClientSide
{
    public class Course
    {

        public int Id { get; set; }                                   // Create auto
        public string? Name { get; set; }                              //b7ot feha ely e5trto mel course Category
        public string CourseImagePath { get; set; } = "/Images/DefaultCourseImg.png";              // b7ot feha el category img bta3t elcourse ely e5trto 
        public string? Description { get; set; }                       // Enter By User
        public DateTime StartAt { get; set; }                         // Enter By User
        public DateTime EndAt { get; set; }                           // Enter By User
        public int? Hours { get; set; }                               // Enter By Redeem Code
        public int? NumberOfTrainees { get; set; }
        public double? TotalFilesSize { get; set; }                   // Maximum Alloable DataSize for this Coruse in Gegabyte
        public int? NumberOfAssessment { get; set; }
        public int? NumberOfLessons { get; set; }
        public string? Location { get; set; }                         // Location of the course
        public string? RedeemCode { get; set; }                       // RedeemCode of the course
        public string CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public int Price { get; set; }

        public int Rating { get; set; }
        public int ReviewCount { get; set; }

        #region Foriegn Keys
        // MyNew Data
        [ForeignKey("instructor")]
        public int instructorId { get; set; }
        public instructor? Instructor { get; set; }
        public List<CourseTrainee>? Trainees {  get; set; }

        // One-to-many relationship with Chapter
        public List<Chapter> Chapters { get; set; } = new List<Chapter>();
        public List<Assessment> Assessments { get; set; } = new List<Assessment>();


        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        #endregion

    }
}

