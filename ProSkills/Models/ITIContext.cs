﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProSkills.Models.AdminPanel.InstructorManger;
using ProSkills.Models.ClientSide;
using Category = ProSkills.Models.ClientSide.Category;

namespace ProSkills.Models
{

    public class ITIContext : IdentityDbContext<ApplicationUser>
    {
        // 1- Create Database Tables 
        // ====> DbSet<Class> TableName   
        public DbSet<instructor> instructor { get; set; }
        public DbSet<Trainee> Trainee { get; set; }
        public DbSet<CourseTrainee> CourseTrainee { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Category> Category{ get; set; }
        public DbSet<Package> Package { get; set; }
        public DbSet<RedeemCode> RedeemCode { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Lesson> Lessons { get; set; }


        // --------------------------------------------------------------------
        // 2- Restore Constructor from Parent DBContext


        public ITIContext(DbContextOptions<ITIContext> options) : base(options) //injection
        {

        }


        // 4- Add some data in table
        // using onModelCreating like intalize DB
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            // Add Instructor
            modelBuilder.Entity<instructor>().HasData(
                    new instructor { Id = 1, Name = "Instructor 1", Email = "instructor1@example.com", Password = "password1", Bio = "Bio for Instructor 1", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 2, Name = "Instructor 2", Email = "instructor2@example.com", Password = "password2", Bio = "Bio for Instructor 2", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 3, Name = "Instructor 3", Email = "instructor3@example.com", Password = "password3", Bio = "Bio for Instructor 3", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 4, Name = "Instructor 4", Email = "instructor4@example.com", Password = "password4", Bio = "Bio for Instructor 4", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 5, Name = "Instructor 5", Email = "instructor5@example.com", Password = "password5", Bio = "Bio for Instructor 5", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 6, Name = "Instructor 6", Email = "instructor6@example.com", Password = "password6", Bio = "Bio for Instructor 6", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 7, Name = "Instructor 7", Email = "instructor7@example.com", Password = "password7", Bio = "Bio for Instructor 7", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 8, Name = "Instructor 8", Email = "instructor8@example.com", Password = "password8", Bio = "Bio for Instructor 8", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 9, Name = "Instructor 9", Email = "instructor9@example.com", Password = "password9", Bio = "Bio for Instructor 9", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 10, Name = "Instructor 10", Email = "instructor10@example.com", Password = "password10", Bio = "Bio for Instructor 10", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 11, Name = "Instructor 11", Email = "instructor11@example.com", Password = "password11", Bio = "Bio for Instructor 11", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 12, Name = "Instructor 12", Email = "instructor12@example.com", Password = "password12", Bio = "Bio for Instructor 12", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 13, Name = "Instructor 13", Email = "instructor13@example.com", Password = "password13", Bio = "Bio for Instructor 13", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 14, Name = "Instructor 14", Email = "instructor14@example.com", Password = "password14", Bio = "Bio for Instructor 14", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 15, Name = "Instructor 15", Email = "instructor15@example.com", Password = "password15", Bio = "Bio for Instructor 15", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 16, Name = "Instructor 16", Email = "instructor16@example.com", Password = "password16", Bio = "Bio for Instructor 16", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 17, Name = "Instructor 17", Email = "instructor17@example.com", Password = "password17", Bio = "Bio for Instructor 17", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 18, Name = "Instructor 18", Email = "instructor18@example.com", Password = "password18", Bio = "Bio for Instructor 18", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 19, Name = "Instructor 19", Email = "instructor19@example.com", Password = "password19", Bio = "Bio for Instructor 19", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 20, Name = "Instructor 20", Email = "instructor20@example.com", Password = "password20", Bio = "Bio for Instructor 20", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 21, Name = "Instructor 21", Email = "instructor21@example.com", Password = "password21", Bio = "Bio for Instructor 21", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 22, Name = "Instructor 22", Email = "instructor22@example.com", Password = "password22", Bio = "Bio for Instructor 22", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 23, Name = "Instructor 23", Email = "instructor23@example.com", Password = "password23", Bio = "Bio for Instructor 23", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 24, Name = "Instructor 24", Email = "instructor24@example.com", Password = "password24", Bio = "Bio for Instructor 24", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 25, Name = "Instructor 25", Email = "instructor25@example.com", Password = "password25", Bio = "Bio for Instructor 25", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 26, Name = "Instructor 26", Email = "instructor26@example.com", Password = "password26", Bio = "Bio for Instructor 26", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 27, Name = "Instructor 27", Email = "instructor27@example.com", Password = "password27", Bio = "Bio for Instructor 27", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 28, Name = "Instructor 28", Email = "instructor28@example.com", Password = "password28", Bio = "Bio for Instructor 28", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 29, Name = "Instructor 29", Email = "instructor29@example.com", Password = "password29", Bio = "Bio for Instructor 29", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 30, Name = "Instructor 30", Email = "instructor30@example.com", Password = "password30", Bio = "Bio for Instructor 30", CreatedAt = DateTime.Now.ToString(), IsDeleted = false }
                );

            // Add Trainee
            modelBuilder.Entity<Trainee>().HasData(
                    new Trainee { Id = 1, Name = "Trainee 1", Email = "Trainee1@example.com", Password = "password1", Bio = "Bio for Trainee 1", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 2, Name = "Trainee 2", Email = "Trainee2@example.com", Password = "password2", Bio = "Bio for Trainee 2", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 3, Name = "Trainee 3", Email = "Trainee3@example.com", Password = "password3", Bio = "Bio for Trainee 3", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 4, Name = "Trainee 4", Email = "Trainee4@example.com", Password = "password4", Bio = "Bio for Trainee 4", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 5, Name = "Trainee 5", Email = "Trainee5@example.com", Password = "password5", Bio = "Bio for Trainee 5", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 6, Name = "Trainee 6", Email = "Trainee6@example.com", Password = "password6", Bio = "Bio for Trainee 6", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 7, Name = "Trainee 7", Email = "Trainee7@example.com", Password = "password7", Bio = "Bio for Trainee 7", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 8, Name = "Trainee 8", Email = "Trainee8@example.com", Password = "password8", Bio = "Bio for Trainee 8", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 9, Name = "Trainee 9", Email = "Trainee9@example.com", Password = "password9", Bio = "Bio for Trainee 9", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 10, Name = "Trainee 10", Email = "Trainee10@example.com", Password = "password10", Bio = "Bio for Trainee 10", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 11, Name = "Trainee 11", Email = "Trainee11@example.com", Password = "password11", Bio = "Bio for Trainee 11", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 12, Name = "Trainee 12", Email = "Trainee12@example.com", Password = "password12", Bio = "Bio for Trainee 12", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 13, Name = "Trainee 13", Email = "Trainee13@example.com", Password = "password13", Bio = "Bio for Trainee 13", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 14, Name = "Trainee 14", Email = "Trainee14@example.com", Password = "password14", Bio = "Bio for Trainee 14", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 15, Name = "Trainee 15", Email = "Trainee15@example.com", Password = "password15", Bio = "Bio for Trainee 15", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 16, Name = "Trainee 16", Email = "Trainee16@example.com", Password = "password16", Bio = "Bio for Trainee 16", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 17, Name = "Trainee 17", Email = "Trainee17@example.com", Password = "password17", Bio = "Bio for Trainee 17", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 18, Name = "Trainee 18", Email = "Trainee18@example.com", Password = "password18", Bio = "Bio for Trainee 18", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 19, Name = "Trainee 19", Email = "Trainee19@example.com", Password = "password19", Bio = "Bio for Trainee 19", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 20, Name = "Trainee 20", Email = "Trainee20@example.com", Password = "password20", Bio = "Bio for Trainee 20", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 21, Name = "Trainee 21", Email = "Trainee21@example.com", Password = "password21", Bio = "Bio for Trainee 21", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 22, Name = "Trainee 22", Email = "Trainee22@example.com", Password = "password22", Bio = "Bio for Trainee 22", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 23, Name = "Trainee 23", Email = "Trainee23@example.com", Password = "password23", Bio = "Bio for Trainee 23", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 24, Name = "Trainee 24", Email = "Trainee24@example.com", Password = "password24", Bio = "Bio for Trainee 24", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 25, Name = "Trainee 25", Email = "Trainee25@example.com", Password = "password25", Bio = "Bio for Trainee 25", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 26, Name = "Trainee 26", Email = "Trainee26@example.com", Password = "password26", Bio = "Bio for Trainee 26", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 27, Name = "Trainee 27", Email = "Trainee27@example.com", Password = "password27", Bio = "Bio for Trainee 27", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 28, Name = "Trainee 28", Email = "Trainee28@example.com", Password = "password28", Bio = "Bio for Trainee 28", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 29, Name = "Trainee 29", Email = "Trainee29@example.com", Password = "password29", Bio = "Bio for Trainee 29", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 30, Name = "Trainee 30", Email = "Trainee30@example.com", Password = "password30", Bio = "Bio for Trainee 30", CreatedAt = DateTime.Now.ToString(), IsDeleted = false }
                );

            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, Name = "Introduction to Programming", CourseImagePath = "path/to/trainee/image.jpg", Description = "This course provides an introduction to programming concepts and techniques.", StartAt = DateTime.Now.AddDays(7), EndAt = DateTime.Now.AddDays(30), CreatedAt = DateTime.Now.ToString(), Hours = 40, NumberOfTrainees = 25, TotalFilesSize = 10.5, NumberOfAssessment = 5, NumberOfLessons = 20, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 2, Name = "Web Development Fundamentals", CourseImagePath = "path/to/trainee/image.jpg", Description = "This course covers the basics of web development including HTML, CSS, and JavaScript.", StartAt = DateTime.Now.AddDays(14), EndAt = DateTime.Now.AddDays(45), CreatedAt = DateTime.Now.ToString(), Hours = 60, NumberOfTrainees = 30, TotalFilesSize = 15.2, NumberOfAssessment = 7, NumberOfLessons = 25, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 3, Name = "Data Structures and Algorithms", CourseImagePath = "path/to/trainee/image.jpg", Description = "This course covers fundamental data structures and algorithms.", StartAt = DateTime.Now.AddDays(5), EndAt = DateTime.Now.AddDays(35), CreatedAt = DateTime.Now.ToString(), Hours = 45, NumberOfTrainees = 20, TotalFilesSize = 11.7, NumberOfAssessment = 6, NumberOfLessons = 22, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16), Instructor = null },
                new Course { Id = 4, Name = "Machine Learning Basics", CourseImagePath = "path/to/trainee/image.jpg", Description = "This course provides an introduction to machine learning concepts and techniques.", StartAt = DateTime.Now.AddDays(10), EndAt = DateTime.Now.AddDays(60), CreatedAt = DateTime.Now.ToString(), Hours = 55, NumberOfTrainees = 25, TotalFilesSize = 13.5, NumberOfAssessment = 6, NumberOfLessons = 23, Location = "Online", IsDeleted = false, instructorId = new Random().Next(4, 16) },
                new Course { Id = 5, Name = "Database Design and Management", CourseImagePath = "path/to/trainee/image.jpg", Description = "This course covers the design and management of relational databases.", StartAt = DateTime.Now.AddDays(7), EndAt = DateTime.Now.AddDays(40), CreatedAt = DateTime.Now.ToString(), Hours = 50, NumberOfTrainees = 30, TotalFilesSize = 14.1, NumberOfAssessment = 7, NumberOfLessons = 25, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 6, Name = "Cybersecurity Fundamentals", CourseImagePath = "path/to/trainee/image.jpg", Description = "This course provides an overview of cybersecurity concepts and principles.", StartAt = DateTime.Now.AddDays(12), EndAt = DateTime.Now.AddDays(50), CreatedAt = DateTime.Now.ToString(), Hours = 55, NumberOfTrainees = 25, TotalFilesSize = 12.3, NumberOfAssessment = 6, NumberOfLessons = 24, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 7, Name = "Artificial Intelligence Basics", CourseImagePath = "path/to/trainee/image.jpg", Description = "This course covers fundamental concepts and techniques in artificial intelligence.", StartAt = DateTime.Now.AddDays(8), EndAt = DateTime.Now.AddDays(55), CreatedAt = DateTime.Now.ToString(), Hours = 50, NumberOfTrainees = 20, TotalFilesSize = 12.8, NumberOfAssessment = 6, NumberOfLessons = 23, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 8, Name = "Software Engineering Principles", CourseImagePath = "path/to/trainee/image.jpg", Description = "This course covers software engineering principles and best practices.", StartAt = DateTime.Now.AddDays(6), EndAt = DateTime.Now.AddDays(35), CreatedAt = DateTime.Now.ToString(), Hours = 45, NumberOfTrainees = 30, TotalFilesSize = 13.2, NumberOfAssessment = 6, NumberOfLessons = 22, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 9, Name = "Python Programming Basics", CourseImagePath = "path/to/trainee/image.jpg", Description = "This course covers the basics of Python programming language.", StartAt = DateTime.Now.AddDays(9), EndAt = DateTime.Now.AddDays(40), CreatedAt = DateTime.Now.ToString(), Hours = 40, NumberOfTrainees = 25, TotalFilesSize = 10.8, NumberOfAssessment = 5, NumberOfLessons = 20, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 10, Name = "Data Analysis with Python", CourseImagePath = "path/to/trainee/image.jpg", Description = "This course covers data analysis techniques using Python programming language.", StartAt = DateTime.Now.AddDays(11), EndAt = DateTime.Now.AddDays(45), CreatedAt = DateTime.Now.ToString(), Hours = 50, NumberOfTrainees = 20, TotalFilesSize = 12.2, NumberOfAssessment = 6, NumberOfLessons = 22, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 11, Name = "Java Programming Fundamentals", CourseImagePath = "path/to/trainee/image.jpg", Description = "This course covers the fundamentals of Java programming language.", StartAt = DateTime.Now.AddDays(13), EndAt = DateTime.Now.AddDays(50), CreatedAt = DateTime.Now.ToString(), Hours = 55, NumberOfTrainees = 25, TotalFilesSize = 13.5, NumberOfAssessment = 6, NumberOfLessons = 24, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 12, Name = "Computer Networks Essentials", CourseImagePath = "path/to/trainee/image.jpg", Description = "This course covers essential concepts in computer networks.", StartAt = DateTime.Now.AddDays(10), EndAt = DateTime.Now.AddDays(40), CreatedAt = DateTime.Now.ToString(), Hours = 45, NumberOfTrainees = 30, TotalFilesSize = 13.1, NumberOfAssessment = 6, NumberOfLessons = 22, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 13, Name = "Introduction to Linux", CourseImagePath = "path/to/trainee/image.jpg", Description = "This course provides an introduction to the Linux operating system.", StartAt = DateTime.Now.AddDays(8), EndAt = DateTime.Now.AddDays(35), CreatedAt = DateTime.Now.ToString(), Hours = 40, NumberOfTrainees = 25, TotalFilesSize = 10.6, NumberOfAssessment = 5, NumberOfLessons = 20, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 14, Name = "Mobile App Development Basics", CourseImagePath = "path/to/trainee/image.jpg", Description = "This course covers the basics of mobile app development.", StartAt = DateTime.Now.AddDays(7), EndAt = DateTime.Now.AddDays(30), CreatedAt = DateTime.Now.ToString(), Hours = 35, NumberOfTrainees = 20, TotalFilesSize = 11.2, NumberOfAssessment = 5, NumberOfLessons = 18, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 15, Name = "Frontend Web Development", CourseImagePath = "path/to/trainee/image.jpg", Description = "This course covers frontend web development technologies and frameworks.", StartAt = DateTime.Now.AddDays(14), EndAt = DateTime.Now.AddDays(45), CreatedAt = DateTime.Now.ToString(), Hours = 60, NumberOfTrainees = 30, TotalFilesSize = 15.8, NumberOfAssessment = 7, NumberOfLessons = 25, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16)},
                new Course { Id = 16, Name = "Cloud Computing Fundamentals", CourseImagePath = "path/to/trainee/image.jpg", Description = "This course provides an introduction to cloud computing concepts and services.", StartAt = DateTime.Now.AddDays(5), EndAt = DateTime.Now.AddDays(35), CreatedAt = DateTime.Now.ToString(), Hours = 45, NumberOfTrainees = 25, TotalFilesSize = 12.5, NumberOfAssessment = 6, NumberOfLessons = 22, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 17, Name = "React.js Fundamentals", CourseImagePath = "path/to/trainee/image.jpg", Description = "This course covers the fundamentals of React.js library for building user interfaces.", StartAt = DateTime.Now.AddDays(12), EndAt = DateTime.Now.AddDays(50), CreatedAt = DateTime.Now.ToString(), Hours = 55, NumberOfTrainees = 30, TotalFilesSize = 13.8, NumberOfAssessment = 6, NumberOfLessons = 24, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 18, Name = "Node.js Development", CourseImagePath = "path/to/trainee/image.jpg", Description = "This course covers server-side development with Node.js runtime environment.", StartAt = DateTime.Now.AddDays(8), EndAt = DateTime.Now.AddDays(55), CreatedAt = DateTime.Now.ToString(), Hours = 50, NumberOfTrainees = 20, TotalFilesSize = 12.3, NumberOfAssessment = 6, NumberOfLessons = 23, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 19, Name = "Databases for Developers", CourseImagePath = "path/to/trainee/image.jpg", Description = "This course covers database concepts and technologies for developers.", StartAt = DateTime.Now.AddDays(6), EndAt = DateTime.Now.AddDays(35), CreatedAt = DateTime.Now.ToString(), Hours = 45, NumberOfTrainees = 25, TotalFilesSize = 13.1, NumberOfAssessment = 6, NumberOfLessons = 22, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16)},
                new Course { Id = 20, Name = "Deep Learning Fundamentals", CourseImagePath = "path/to/trainee/image.jpg", Description = "This course provides an introduction to deep learning concepts and techniques.", StartAt = DateTime.Now.AddDays(9), EndAt = DateTime.Now.AddDays(40), CreatedAt = DateTime.Now.ToString(), Hours = 40, NumberOfTrainees = 30, TotalFilesSize = 11.8, NumberOfAssessment = 5, NumberOfLessons = 20, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 21, Name = "Cybersecurity Essentials", CourseImagePath = "path/to/trainee/image.jpg", Description = "This course covers essential cybersecurity concepts and practices.", StartAt = DateTime.Now.AddDays(11), EndAt = DateTime.Now.AddDays(45), CreatedAt = DateTime.Now.ToString(), Hours = 50, NumberOfTrainees = 20, TotalFilesSize = 12.5, NumberOfAssessment = 6, NumberOfLessons = 22, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 22, Name = "Ruby Programming Basics", CourseImagePath = "path/to/trainee/image.jpg", Description = "This course covers the basics of Ruby programming language.", StartAt = DateTime.Now.AddDays(13), EndAt = DateTime.Now.AddDays(50), CreatedAt = DateTime.Now.ToString(), Hours = 55, NumberOfTrainees = 25, TotalFilesSize = 13.2, NumberOfAssessment = 6, NumberOfLessons = 24, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 23, Name = "Computer Architecture Fundamentals", CourseImagePath = "path/to/trainee/image.jpg", Description = "This course covers fundamental concepts in computer architecture.", StartAt = DateTime.Now.AddDays(10), EndAt = DateTime.Now.AddDays(40), CreatedAt = DateTime.Now.ToString(), Hours = 45, NumberOfTrainees = 30, TotalFilesSize = 13.6, NumberOfAssessment = 6, NumberOfLessons = 22, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 24, Name = "JavaScript Programming Basics", CourseImagePath = "path/to/trainee/image.jpg", Description = "This course covers the basics of JavaScript programming language.", StartAt = DateTime.Now.AddDays(8), EndAt = DateTime.Now.AddDays(35), CreatedAt = DateTime.Now.ToString(), Hours = 40, NumberOfTrainees = 25, TotalFilesSize = 10.9, NumberOfAssessment = 5, NumberOfLessons = 20, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 25, Name = "Software Testing Fundamentals", CourseImagePath = "path/to/trainee/image.jpg", Description = "This course covers fundamental concepts and techniques in software testing.", StartAt = DateTime.Now.AddDays(7), EndAt = DateTime.Now.AddDays(30), CreatedAt = DateTime.Now.ToString(), Hours = 35, NumberOfTrainees = 20, TotalFilesSize = 11.4, NumberOfAssessment = 5, NumberOfLessons = 18, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 26, Name = "Angular Framework Fundamentals", CourseImagePath = "path/to/trainee/image.jpg", Description = "This course covers the fundamentals of Angular framework for building web applications.", StartAt = DateTime.Now.AddDays(14), EndAt = DateTime.Now.AddDays(45), CreatedAt = DateTime.Now.ToString(), Hours = 60, NumberOfTrainees = 30, TotalFilesSize = 15.2, NumberOfAssessment = 7, NumberOfLessons = 25, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 27, Name = "iOS App Development Basics", CourseImagePath = "path/to/trainee/image.jpg", Description = "This course covers the basics of iOS app development using Swift programming language.", StartAt = DateTime.Now.AddDays(5), EndAt = DateTime.Now.AddDays(35), CreatedAt = DateTime.Now.ToString(), Hours = 45, NumberOfTrainees = 25, TotalFilesSize = 13.7, NumberOfAssessment = 6, NumberOfLessons = 22, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 28, Name = "ASP.NET Core Development", CourseImagePath = "path/to/trainee/image.jpg", Description = "This course covers server-side web development with ASP.NET Core framework.", StartAt = DateTime.Now.AddDays(12), EndAt = DateTime.Now.AddDays(50), CreatedAt = DateTime.Now.ToString(), Hours = 55, NumberOfTrainees = 30, TotalFilesSize = 14.3, NumberOfAssessment = 6, NumberOfLessons = 24, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 29, Name = "C# Programming Fundamentals", CourseImagePath = "path/to/trainee/image.jpg", Description = "This course covers the fundamentals of C# programming language.", StartAt = DateTime.Now.AddDays(8), EndAt = DateTime.Now.AddDays(55), CreatedAt = DateTime.Now.ToString(), Hours = 50, NumberOfTrainees = 20, TotalFilesSize = 12.6, NumberOfAssessment = 6, NumberOfLessons = 23, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 30, Name = "Unity Game Development Fundamentals", CourseImagePath = "path/to/trainee/image.jpg", Description = "This course covers the fundamentals of game development using Unity game engine.", StartAt = DateTime.Now.AddDays(6), EndAt = DateTime.Now.AddDays(35), CreatedAt = DateTime.Now.ToString(), Hours = 45, NumberOfTrainees = 25, TotalFilesSize = 13.9, NumberOfAssessment = 6, NumberOfLessons = 22, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) }
            );

            // Seed Chapters and Lessons
            var random1 = new Random();
            var chapterId = 1;
            var lessonId = 1;
            var chapters = new List<Chapter>();
            var lessons = new List<Lesson>();

            for (int courseId = 1; courseId <= 10; courseId++)
            {
                var numberOfChapters = random1.Next(2, 4); // Each course has between 3 and 7 chapters
                for (int i = 1; i <= numberOfChapters; i++)
                {
                    chapters.Add(new Chapter
                    {
                        Id = chapterId,
                        Title = $"Chapter {i} for Course {courseId}",
                        Description = $"Description for Chapter {i} in Course {courseId}",
                        CourseId = courseId,
                        downloadLink = "https://sadat.vip/",
                    });

                    var numberOfLessons = random1.Next(2, 4); // Each chapter has between 3 and 10 lessons
                    for (int j = 1; j <= numberOfLessons; j++)
                    {
                        lessons.Add(new Lesson
                        {
                            Id = lessonId,
                            Title = $"Lesson {j} for Chapter {chapterId}",
                            Content = $"Content for Lesson {j} in Chapter {chapterId}",
                            Time = TimeSpan.FromMinutes(random1.Next(10, 60)), // Random lesson time between 10 and 60 minutes
                            ChapterId = chapterId,
                            downloadLink = "https://sadat.vip/",
                            TaskLink = "https://www.youtube.com/watch?v=0W4KRuw7m9U",
                        });
                        lessonId++;
                    }
                    chapterId++;
                }
            }

            modelBuilder.Entity<Chapter>().HasData(chapters);
            modelBuilder.Entity<Lesson>().HasData(lessons);

            // Generate random CourseTrainee relations
            var random = new Random();
            var courseTraineeData = new List<CourseTrainee>();

            // Assuming we want to create 100 random relations
            for (int i = 1; i <= 100; i++)
            {
                courseTraineeData.Add(new CourseTrainee
                {
                    Id = i,
                    TraineeId = random.Next(1, 31), // Trainee IDs between 1 and 30
                    CourseId = random.Next(1, 31), // Course IDs between 1 and 30
                    Result = (decimal)(random.NextDouble() * 100), // Random result between 0 and 100
                });
            }
            modelBuilder.Entity<CourseTrainee>().HasData(courseTraineeData);

            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, Name = "Revit", CreatedAt = DateTime.Now.ToString(),Image="", IsDeleted = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, Name = "Sap", CreatedAt = DateTime.Now.ToString(), Image = "", IsDeleted = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, Name = "Etabs", CreatedAt = DateTime.Now.ToString(), Image = "", IsDeleted = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 4, Name = "Forge", CreatedAt = DateTime.Now.ToString(), Image = "", IsDeleted = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 5, Name = "primavera", CreatedAt = DateTime.Now.ToString(), Image = "", IsDeleted = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 6, Name = "wpf", CreatedAt = DateTime.Now.ToString(), Image = "", IsDeleted = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 7, Name = "Windows Form", CreatedAt = DateTime.Now.ToString(), Image = "", IsDeleted = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 8, Name = "NavisWorks", CreatedAt = DateTime.Now.ToString(), Image = "", IsDeleted = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 9, Name = "Graphics", CreatedAt = DateTime.Now.ToString(), Image = "", IsDeleted = false });



            ////////////////////////seeding data for packages
              modelBuilder.Entity<Package>().HasData(new Package { Id = 1, Name = "free", Image = "image1.jpg", Hours = 10, NumberOfTrainees = 20, NumberOfAssesments = 5, NumberOfLessons = 15, TotlaFileSize = 1024, CreatedAt = DateTime.Now.ToString(), IsDeleted = false });
              modelBuilder.Entity<Package>().HasData(new Package { Id = 2, Name = "Premium", Image = "image2.jpg", Hours = 10, NumberOfTrainees = 40, NumberOfAssesments = 5, NumberOfLessons = 15, TotlaFileSize = 1024, CreatedAt = DateTime.Now.ToString(), IsDeleted = false });
              modelBuilder.Entity<Package>().HasData(new Package { Id = 3, Name = "Advanced" ,Image = "image3.jpg", Hours = 10, NumberOfTrainees = 40, NumberOfAssesments = 5, NumberOfLessons = 15, TotlaFileSize = 1024, CreatedAt = DateTime.Now.ToString(), IsDeleted = false });

            /////seeding data for redeemcode
            modelBuilder.Entity<RedeemCode>().HasData(new RedeemCode { Id = 3, Code="gamal", packageid = 1,PackageName="premium", CreatedAt = DateTime.Now.ToString(), IsDeleted = false });

            base.OnModelCreating(modelBuilder);
        }


    }

}


