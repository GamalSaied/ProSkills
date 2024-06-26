﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
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
        public DbSet<Category> Category { get; set; }
        public DbSet<Package> Package { get; set; }
        public DbSet<RedeemCode> RedeemCode { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<ActivityLog> ActivityLogs { get; set; }
        public DbSet<JoinRequest> JoinRequests { get; set; }


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
                    new instructor { Id = 1, Name = "Instructor 1 Name", Email = "instructor1@example.com", Password = "password1", Bio = "Bio for Instructor 1", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 2, Name = "Instructor 2 Name", Email = "instructor2@example.com", Password = "password2", Bio = "Bio for Instructor 2", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 3, Name = "Instructor 3 Name", Email = "instructor3@example.com", Password = "password3", Bio = "Bio for Instructor 3", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 4, Name = "Instructor 4 Name", Email = "instructor4@example.com", Password = "password4", Bio = "Bio for Instructor 4", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 5, Name = "Instructor 5 Name", Email = "instructor5@example.com", Password = "password5", Bio = "Bio for Instructor 5", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 6, Name = "Instructor 6 Name", Email = "instructor6@example.com", Password = "password6", Bio = "Bio for Instructor 6", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 7, Name = "Instructor 7 Name", Email = "instructor7@example.com", Password = "password7", Bio = "Bio for Instructor 7", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 8, Name = "Instructor 8 Name", Email = "instructor8@example.com", Password = "password8", Bio = "Bio for Instructor 8", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 9, Name = "Instructor 9 Name", Email = "instructor9@example.com", Password = "password9", Bio = "Bio for Instructor 9", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 10, Name = "Instructor 10 Name", Email = "instructor10@example.com", Password = "password10", Bio = "Bio for Instructor 10", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 11, Name = "Instructor 11 Name", Email = "instructor11@example.com", Password = "password11", Bio = "Bio for Instructor 11", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 12, Name = "Instructor 12 Name", Email = "instructor12@example.com", Password = "password12", Bio = "Bio for Instructor 12", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 13, Name = "Instructor 13 Name", Email = "instructor13@example.com", Password = "password13", Bio = "Bio for Instructor 13", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 14, Name = "Instructor 14 Name", Email = "instructor14@example.com", Password = "password14", Bio = "Bio for Instructor 14", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 15, Name = "Instructor 15 Name", Email = "instructor15@example.com", Password = "password15", Bio = "Bio for Instructor 15", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 16, Name = "Instructor 16 Name", Email = "instructor16@example.com", Password = "password16", Bio = "Bio for Instructor 16", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 17, Name = "Instructor 17 Name", Email = "instructor17@example.com", Password = "password17", Bio = "Bio for Instructor 17", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 18, Name = "Instructor 18 Name", Email = "instructor18@example.com", Password = "password18", Bio = "Bio for Instructor 18", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 19, Name = "Instructor 19 Name", Email = "instructor19@example.com", Password = "password19", Bio = "Bio for Instructor 19", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new instructor { Id = 20, Name = "Instructor 20 Name", Email = "instructor20@example.com", Password = "password20", Bio = "Bio for Instructor 20", CreatedAt = DateTime.Now.ToString(), IsDeleted = false }
                    );

            // Add Trainee
            modelBuilder.Entity<Trainee>().HasData(
                    new Trainee { Id = 1, Name = "Trainee 1 Name", Email = "Trainee1@example.com", Bio = "Bio for Trainee 1", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 2, Name = "Trainee 2 Name", Email = "Trainee2@example.com", Bio = "Bio for Trainee 2", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 3, Name = "Trainee 3 Name", Email = "Trainee3@example.com", Bio = "Bio for Trainee 3", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 4, Name = "Trainee 4 Name", Email = "Trainee4@example.com", Bio = "Bio for Trainee 4", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 5, Name = "Trainee 5 Name", Email = "Trainee5@example.com", Bio = "Bio for Trainee 5", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 6, Name = "Trainee 6 Name", Email = "Trainee6@example.com", Bio = "Bio for Trainee 6", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 7, Name = "Trainee 7 Name", Email = "Trainee7@example.com", Bio = "Bio for Trainee 7", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 8, Name = "Trainee 8 Name", Email = "Trainee8@example.com", Bio = "Bio for Trainee 8", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 9, Name = "Trainee 9 Name", Email = "Trainee9@example.com", Bio = "Bio for Trainee 9", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 10, Name = "Trainee 10 Name", Email = "Trainee10@example.com", Bio = "Bio for Trainee 10", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 11, Name = "Trainee 11 Name", Email = "Trainee11@example.com", Bio = "Bio for Trainee 11", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 12, Name = "Trainee 12 Name", Email = "Trainee12@example.com", Bio = "Bio for Trainee 12", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 13, Name = "Trainee 13 Name", Email = "Trainee13@example.com", Bio = "Bio for Trainee 13", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 14, Name = "Trainee 14 Name", Email = "Trainee14@example.com", Bio = "Bio for Trainee 14", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 15, Name = "Trainee 15 Name", Email = "Trainee15@example.com", Bio = "Bio for Trainee 15", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 16, Name = "Trainee 16 Name", Email = "Trainee16@example.com", Bio = "Bio for Trainee 16", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 17, Name = "Trainee 17 Name", Email = "Trainee17@example.com", Bio = "Bio for Trainee 17", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 18, Name = "Trainee 18 Name", Email = "Trainee18@example.com", Bio = "Bio for Trainee 18", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 19, Name = "Trainee 19 Name", Email = "Trainee19@example.com", Bio = "Bio for Trainee 19", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 20, Name = "Trainee 20 Name", Email = "Trainee20@example.com", Bio = "Bio for Trainee 20", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 21, Name = "Trainee 21 Name", Email = "Trainee21@example.com", Bio = "Bio for Trainee 21", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 22, Name = "Trainee 22 Name", Email = "Trainee22@example.com", Bio = "Bio for Trainee 22", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 23, Name = "Trainee 23 Name", Email = "Trainee23@example.com", Bio = "Bio for Trainee 23", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 24, Name = "Trainee 24 Name", Email = "Trainee24@example.com", Bio = "Bio for Trainee 24", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 25, Name = "Trainee 25 Name", Email = "Trainee25@example.com", Bio = "Bio for Trainee 25", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 26, Name = "Trainee 26 Name", Email = "Trainee26@example.com", Bio = "Bio for Trainee 26", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 27, Name = "Trainee 27 Name", Email = "Trainee27@example.com", Bio = "Bio for Trainee 27", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 28, Name = "Trainee 28 Name", Email = "Trainee28@example.com", Bio = "Bio for Trainee 28", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 29, Name = "Trainee 29 Name", Email = "Trainee29@example.com", Bio = "Bio for Trainee 29", CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                    new Trainee { Id = 30, Name = "Trainee 30 Name", Email = "Trainee30@example.com", Bio = "Bio for Trainee 30", CreatedAt = DateTime.Now.ToString(), IsDeleted = false }
                );
            base.OnModelCreating(modelBuilder);

            // Seed roles
            string adminRoleId = "1";
            string instructorRoleId = "2";
            string traineeRoleId = "3";

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = adminRoleId, Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = instructorRoleId, Name = "Instructor", NormalizedName = "INSTRUCTOR" },
                new IdentityRole { Id = traineeRoleId, Name = "Trainee", NormalizedName = "TRAINEE" }
            );

            // Seed users
            var hasher = new PasswordHasher<ApplicationUser>();
            string adminUserId = "1";
            string user2Id = "2";
            string user3Id = "3";

            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = adminUserId,
                    UserName = "ahmed9821hussein@gmail.com",
                    NormalizedUserName = "AHMED9821HUSSEIN@GMAIL.COM",
                    Email = "ahmed9821hussein@gmail.com",
                    NormalizedEmail = "AHMED9821HUSSEIN@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "ahmed123"),
                    SecurityStamp = string.Empty,
                    Phone = "01015983533",
                    PhoneNumberConfirmed = true,
                    FullName = "Ahmed Hussein",
                    ProfilePictureUrl = "\\Images\\profiles\\profile-picture.jpg"
                },
                new ApplicationUser
                {
                    Id = user2Id,
                    UserName = "MuhammedSadat@outlook.com",
                    NormalizedUserName = "MUHAMMEDSADAT@OUTLOOK.COM",
                    Email = "MuhammedSadat@outlook.com",
                    NormalizedEmail = "MUHAMMEDSADAT@OUTLOOK.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "sadat123"),
                    SecurityStamp = string.Empty,
                    FullName = "Muhammed Sadat",
                    Phone = "01050403037"
                },
                new ApplicationUser
                {
                    Id = user3Id,
                    UserName = "gamalsaied.90@gmail.com",
                    NormalizedUserName = "GAMALSAIED.90@GMAIL.COM",
                    Email = "gamalsaied.90@gmail.com",
                    NormalizedEmail = "GAMALSAIED.90@GMAIL.COM",
                    EmailConfirmed = true,
                    Phone = "01033901616",
                    PasswordHash = hasher.HashPassword(null, "gamal123"),
                    SecurityStamp = string.Empty,
                    FullName = "Gamal Said"
                }
            );

            // Assign roles to users
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { RoleId = adminRoleId, UserId = adminUserId },
                new IdentityUserRole<string> { RoleId = adminRoleId, UserId = user2Id },
                new IdentityUserRole<string> { RoleId = adminRoleId, UserId = user3Id }
            );

            // Seed trainees
            modelBuilder.Entity<Trainee>().HasData(
                new Trainee
                {
                    Id = 31,
                    Name = "Ahmed Hussein",
                    Email = "ahmed9821hussein@gmail.com",
                    Phone = "01015983533",
                    ProfilePictureUrl = "\\Images\\profiles\\profile-picture.jpg",
                    CreatedAt = DateTime.Now.ToString(),
                    IsDeleted = false
                },
                new Trainee
                {
                    Id = 32,
                    Name = "Muhammed Sadat",
                    Email = "MuhammedSadat@outlook.com",
                    CreatedAt = DateTime.Now.ToString(),
                    Phone = "01050403037",
                    IsDeleted = false
                },
                new Trainee
                {
                    Id = 33,
                    Name = "Gamal Said",
                    Email = "gamalsaied.90@gmail.com",
                    Phone = "01033901616",
                    CreatedAt = DateTime.Now.ToString(),
                    IsDeleted = false
                }
            );



            // Seed categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "BIM Software", Description = "Building Information Modeling software", Image = "path/to/bim/image.jpg", CreatedAt = DateTime.Now.ToString() },
                new Category { Id = 2, Name = "CAD Software", Description = "Computer-Aided Design software", Image = "path/to/cad/image.jpg", CreatedAt = DateTime.Now.ToString() },
                new Category { Id = 3, Name = "Construction Software", Description = "Software for construction planning and management", Image = "path/to/construction/image.jpg", CreatedAt = DateTime.Now.ToString() },
                new Category { Id = 4, Name = "Structural Engineering Software", Description = "Software for structural engineering analysis and design", Image = "path/to/structural/image.jpg", CreatedAt = DateTime.Now.ToString() },
                new Category { Id = 5, Name = "Civil Engineering Software", Description = "Software for civil engineering design and analysis", Image = "path/to/civil/image.jpg", CreatedAt = DateTime.Now.ToString() },
                new Category { Id = 6, Name = "Project Management Software", Description = "Software for project management", Image = "path/to/project/image.jpg", CreatedAt = DateTime.Now.ToString() },
                new Category { Id = 7, Name = "Advanced BIM Software", Description = "Advanced Building Information Modeling software", Image = "path/to/advanced_bim/image.jpg", CreatedAt = DateTime.Now.ToString() }
            );

            // Seed courses and associate them with categories
            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, Name = "Structural Revit", CategoryId = 1, Description = "Learn Structural Revit", StartAt = DateTime.Now.AddDays(7), EndAt = DateTime.Now.AddDays(30), CreatedAt = DateTime.Now.ToString(), Hours = 40, NumberOfTrainees = 25, TotalFilesSize = 10.5, NumberOfAssessment = 5, NumberOfLessons = 20, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 2, Name = "Arch Revit", CategoryId = 1, Description = "Learn Arch Revit", StartAt = DateTime.Now.AddDays(14), EndAt = DateTime.Now.AddDays(45), CreatedAt = DateTime.Now.ToString(), Hours = 60, NumberOfTrainees = 30, TotalFilesSize = 15.2, NumberOfAssessment = 7, NumberOfLessons = 25, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 3, Name = "MEP Revit", CategoryId = 1, Description = "Learn MEP Revit", StartAt = DateTime.Now.AddDays(5), EndAt = DateTime.Now.AddDays(35), CreatedAt = DateTime.Now.ToString(), Hours = 45, NumberOfTrainees = 20, TotalFilesSize = 11.7, NumberOfAssessment = 6, NumberOfLessons = 22, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 4, Name = "Structural AutoCAD", CategoryId = 2, Description = "Learn Structural AutoCAD", StartAt = DateTime.Now.AddDays(10), EndAt = DateTime.Now.AddDays(60), CreatedAt = DateTime.Now.ToString(), Hours = 55, NumberOfTrainees = 25, TotalFilesSize = 13.5, NumberOfAssessment = 6, NumberOfLessons = 23, Location = "Online", IsDeleted = false, instructorId = new Random().Next(4, 16) },
                new Course { Id = 5, Name = "Arch AutoCAD", CategoryId = 2, Description = "Learn Arch AutoCAD", StartAt = DateTime.Now.AddDays(7), EndAt = DateTime.Now.AddDays(40), CreatedAt = DateTime.Now.ToString(), Hours = 50, NumberOfTrainees = 30, TotalFilesSize = 14.1, NumberOfAssessment = 7, NumberOfLessons = 25, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 6, Name = "MEP AutoCAD", CategoryId = 2, Description = "Learn MEP AutoCAD", StartAt = DateTime.Now.AddDays(12), EndAt = DateTime.Now.AddDays(50), CreatedAt = DateTime.Now.ToString(), Hours = 55, NumberOfTrainees = 25, TotalFilesSize = 12.3, NumberOfAssessment = 6, NumberOfLessons = 24, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 7, Name = "3D AutoCAD", CategoryId = 2,  Description = "Learn 3D AutoCAD", StartAt = DateTime.Now.AddDays(8), EndAt = DateTime.Now.AddDays(55), CreatedAt = DateTime.Now.ToString(), Hours = 50, NumberOfTrainees = 20, TotalFilesSize = 12.8, NumberOfAssessment = 6, NumberOfLessons = 23, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 8, Name = "Tekla", CategoryId = 3,  Description = "Learn Tekla", StartAt = DateTime.Now.AddDays(6), EndAt = DateTime.Now.AddDays(35), CreatedAt = DateTime.Now.ToString(), Hours = 45, NumberOfTrainees = 30, TotalFilesSize = 13.2, NumberOfAssessment = 6, NumberOfLessons = 22, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 9, Name = "SketchUP", CategoryId = 3,  Description = "Learn SketchUP", StartAt = DateTime.Now.AddDays(9), EndAt = DateTime.Now.AddDays(40), CreatedAt = DateTime.Now.ToString(), Hours = 40, NumberOfTrainees = 25, TotalFilesSize = 10.8, NumberOfAssessment = 5, NumberOfLessons = 20, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 10, Name = "SAP 2000", CategoryId = 4, Description = "Learn SAP 2000", StartAt = DateTime.Now.AddDays(11), EndAt = DateTime.Now.AddDays(45), CreatedAt = DateTime.Now.ToString(), Hours = 50, NumberOfTrainees = 20, TotalFilesSize = 12.2, NumberOfAssessment = 6, NumberOfLessons = 22, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 11, Name = "STAAD Pro", CategoryId = 4,  Description = "Learn STAAD Pro", StartAt = DateTime.Now.AddDays(13), EndAt = DateTime.Now.AddDays(50), CreatedAt = DateTime.Now.ToString(), Hours = 55, NumberOfTrainees = 25, TotalFilesSize = 13.5, NumberOfAssessment = 6, NumberOfLessons = 24, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 12, Name = "CIVIL 3D", CategoryId = 5, Description = "Learn CIVIL 3D", StartAt = DateTime.Now.AddDays(10), EndAt = DateTime.Now.AddDays(40), CreatedAt = DateTime.Now.ToString(), Hours = 45, NumberOfTrainees = 30, TotalFilesSize = 13.1, NumberOfAssessment = 6, NumberOfLessons = 22, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 13, Name = "ETABS", CategoryId = 4, Description = "Learn ETABS", StartAt = DateTime.Now.AddDays(8), EndAt = DateTime.Now.AddDays(35), CreatedAt = DateTime.Now.ToString(), Hours = 40, NumberOfTrainees = 25, TotalFilesSize = 10.6, NumberOfAssessment = 5, NumberOfLessons = 20, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 14, Name = "SAFE", CategoryId = 4,  Description = "Learn SAFE", StartAt = DateTime.Now.AddDays(7), EndAt = DateTime.Now.AddDays(30), CreatedAt = DateTime.Now.ToString(), Hours = 35, NumberOfTrainees = 20, TotalFilesSize = 11.2, NumberOfAssessment = 5, NumberOfLessons = 18, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 15, Name = "Primavera P6", CategoryId = 6,  Description = "Learn Primavera P6", StartAt = DateTime.Now.AddDays(14), EndAt = DateTime.Now.AddDays(45), CreatedAt = DateTime.Now.ToString(), Hours = 60, NumberOfTrainees = 30, TotalFilesSize = 15.8, NumberOfAssessment = 7, NumberOfLessons = 25, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 16, Name = "Microsoft Project", CategoryId = 6,Description = "Learn Microsoft Project", StartAt = DateTime.Now.AddDays(5), EndAt = DateTime.Now.AddDays(35), CreatedAt = DateTime.Now.ToString(), Hours = 45, NumberOfTrainees = 25, TotalFilesSize = 12.5, NumberOfAssessment = 6, NumberOfLessons = 22, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 17, Name = "Navisworks", CategoryId = 3,  Description = "Learn Navisworks", StartAt = DateTime.Now.AddDays(12), EndAt = DateTime.Now.AddDays(50), CreatedAt = DateTime.Now.ToString(), Hours = 55, NumberOfTrainees = 30, TotalFilesSize = 13.8, NumberOfAssessment = 6, NumberOfLessons = 24, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 18, Name = "Revit Structure Advanced", CategoryId = 7, Description = "Learn Advanced Revit Structure", StartAt = DateTime.Now.AddDays(8), EndAt = DateTime.Now.AddDays(55), CreatedAt = DateTime.Now.ToString(), Hours = 50, NumberOfTrainees = 20, TotalFilesSize = 12.3, NumberOfAssessment = 6, NumberOfLessons = 23, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 19, Name = "Revit Architecture Advanced", CategoryId = 7, Description = "Learn Advanced Revit Architecture", StartAt = DateTime.Now.AddDays(6), EndAt = DateTime.Now.AddDays(35), CreatedAt = DateTime.Now.ToString(), Hours = 45, NumberOfTrainees = 25, TotalFilesSize = 13.7, NumberOfAssessment = 6, NumberOfLessons = 22, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) },
                new Course { Id = 20, Name = "Revit MEP Advanced", CategoryId = 7, Description = "Learn Advanced Revit MEP", StartAt = DateTime.Now.AddDays(7), EndAt = DateTime.Now.AddDays(30), CreatedAt = DateTime.Now.ToString(), Hours = 35, NumberOfTrainees = 20, TotalFilesSize = 11.4, NumberOfAssessment = 5, NumberOfLessons = 18, Location = "Online", IsDeleted = false, instructorId = new Random().Next(1, 16) }
            );
            modelBuilder.Entity<Chapter>().HasData(
      new Chapter { Id = 1, Title = "Introduction to Structural Revit", Description = "Basics of Structural Revit", CourseId = 1, downloadLink = "https://sadat.vip/", IsDeleted = false },
      new Chapter { Id = 2, Title = "Advanced Structural Elements", Description = "Detailed look into advanced elements", CourseId = 1, downloadLink = "https://sadat.vip/", IsDeleted = false },
      new Chapter { Id = 3, Title = "Structural Revit Best Practices", Description = "Best practices for using Structural Revit", CourseId = 1, downloadLink = "https://sadat.vip/", IsDeleted = false },
      new Chapter { Id = 4, Title = "Structural Analysis in Revit", Description = "Conducting structural analysis", CourseId = 1, downloadLink = "https://sadat.vip/", IsDeleted = false }
  );

            modelBuilder.Entity<Lesson>().HasData(
                // Lessons for Chapter 1
                new Lesson { Id = 1, Title = "Revit Installation and Setup", Content = "Installing Revit and initial setup", Time = TimeSpan.FromMinutes(30), ChapterId = 1, downloadLink = "https://sadat.vip/", TaskLink = "https://www.youtube.com/watch?v=Nd6U2KgHI6k", IsDeleted = false },
                new Lesson { Id = 2, Title = "Basic Structural Elements", Content = "Understanding basic structural elements", Time = TimeSpan.FromMinutes(45), ChapterId = 1, downloadLink = "https://sadat.vip/", TaskLink = "https://www.youtube.com/watch?v=Nd6U2KgHI6k", IsDeleted = false },

                // Lessons for Chapter 2
                new Lesson { Id = 3, Title = "Advanced Structural Design", Content = "Advanced design techniques", Time = TimeSpan.FromMinutes(60), ChapterId = 2, downloadLink = "https://sadat.vip/", TaskLink = "https://www.youtube.com/watch?v=Nd6U2KgHI6k", IsDeleted = false },
                new Lesson { Id = 4, Title = "Complex Structures", Content = "Designing complex structures", Time = TimeSpan.FromMinutes(50), ChapterId = 2, downloadLink = "https://sadat.vip/", TaskLink = "https://www.youtube.com/watch?v=Nd6U2KgHI6k", IsDeleted = false },

                // Lessons for Chapter 3
                new Lesson { Id = 5, Title = "Best Practices Overview", Content = "Overview of best practices", Time = TimeSpan.FromMinutes(40), ChapterId = 3, downloadLink = "https://sadat.vip/", TaskLink = "https://www.youtube.com/watch?v=Nd6U2KgHI6k", IsDeleted = false },
                new Lesson { Id = 6, Title = "Modeling Tips", Content = "Tips for effective modeling", Time = TimeSpan.FromMinutes(35), ChapterId = 3, downloadLink = "https://sadat.vip/", TaskLink = "https://www.youtube.com/watch?v=Nd6U2KgHI6k", IsDeleted = false },

                // Lessons for Chapter 4
                new Lesson { Id = 7, Title = "Introduction to Structural Analysis", Content = "Basics of structural analysis", Time = TimeSpan.FromMinutes(45), ChapterId = 4, downloadLink = "https://sadat.vip/", TaskLink = "https://www.youtube.com/watch?v=Nd6U2KgHI6k", IsDeleted = false },
                new Lesson { Id = 8, Title = "Advanced Analysis Techniques", Content = "Advanced techniques in structural analysis", Time = TimeSpan.FromMinutes(55), ChapterId = 4, downloadLink = "https://sadat.vip/", TaskLink = "https://www.youtube.com/watch?v=Nd6U2KgHI6k", IsDeleted = false }
            );

            modelBuilder.Entity<Assessment>().HasData(
    // Assessment for Grids
    new Assessment
    {
        Id = 1,
        Title = "Grids Task",
        Description = "1- Draw grids on the attached dwg.\n2- Change the size of the Bubble.\n3- Change the text size of inside the bubble.",
        Points = 20,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now,
        CourseId = 1,
        IsDeleted = false
    },

    // Assessment for Columns
    new Assessment
    {
        Id = 2,
        Title = "Columns Task",
        Description = "1- Create the type of column with dimension 25*50 cm2 and .6*.6.\n2- Draw the columns on the attached dwg.",
        Points = 25,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now,
        CourseId = 1,
        IsDeleted = false
    },

    // Assessment for Footings
    new Assessment
    {
        Id = 3,
        Title = "Footings Task",
        Description = "1- Create the type of Footings with dimension 1.5*1.5 and 1*.6.\n2- Draw the Footings on the attached dwg.",
        Points = 25,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now,
        CourseId = 1,
        IsDeleted = false
    },

    // Assessment for Beams
    new Assessment
    {
        Id = 4,
        Title = "Beams Task",
        Description = "1- Create the type of Beams with dimension 25*50.\n2- Draw the Beams on the attached dwg.",
        Points = 25,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now,
        CourseId = 1,
        IsDeleted = false
    },

    // Assessment for Floors
    new Assessment
    {
        Id = 5,
        Title = "Floors Task",
        Description = "1- Create the type of floors generic 300mm.\n2- Draw the floors on the attached dwg.",
        Points = 30,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now,
        CourseId = 1,
        IsDeleted = false
    }
);




            // Generate random CourseTrainee relations
            var courseTraineeData = new List<CourseTrainee>();



            // Seed packages
            modelBuilder.Entity<Package>().HasData(
                new Package { Id = 1, Name = "Free", Image = "image1.jpg", Hours = 10, NumberOfTrainees = 20, NumberOfAssesments = 5, NumberOfLessons = 15, TotlaFileSize = 1024, CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                new Package { Id = 2, Name = "Premium", Image = "image2.jpg", Hours = 10, NumberOfTrainees = 40, NumberOfAssesments = 5, NumberOfLessons = 15, TotlaFileSize = 1024, CreatedAt = DateTime.Now.ToString(), IsDeleted = false },
                new Package { Id = 3, Name = "Advanced", Image = "image3.jpg", Hours = 10, NumberOfTrainees = 40, NumberOfAssesments = 5, NumberOfLessons = 15, TotlaFileSize = 1024, CreatedAt = DateTime.Now.ToString(), IsDeleted = false }
            );

            // Seed redeem codes
            modelBuilder.Entity<RedeemCode>().HasData(
                new RedeemCode { Id = 1, Code = "gamal", packageid = 1, PackageName = "Premium", CreatedAt = DateTime.Now.ToString(), IsDeleted = false }
            );
            // Assign users to "Structural Revit" course with random points
            Random random2 = new Random();
            modelBuilder.Entity<CourseTrainee>().HasData(
        new CourseTrainee { Id = 1, CourseId = 1, TraineeId = 1, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 2, CourseId = 1, TraineeId = 2, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 3, CourseId = 1, TraineeId = 3, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 4, CourseId = 1, TraineeId = 4, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 5, CourseId = 1, TraineeId = 5, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 6, CourseId = 1, TraineeId = 6, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 7, CourseId = 1, TraineeId = 7, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 8, CourseId = 1, TraineeId = 8, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 9, CourseId = 1, TraineeId = 9, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 10, CourseId = 1, TraineeId = 10, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 11, CourseId = 1, TraineeId = 11, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 12, CourseId = 1, TraineeId = 12, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 13, CourseId = 1, TraineeId = 13, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 14, CourseId = 1, TraineeId = 14, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 15, CourseId = 1, TraineeId = 15, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 16, CourseId = 1, TraineeId = 16, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 17, CourseId = 1, TraineeId = 17, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 18, CourseId = 1, TraineeId = 18, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 19, CourseId = 1, TraineeId = 19, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 20, CourseId = 1, TraineeId = 20, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 21, CourseId = 1, TraineeId = 21, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 22, CourseId = 1, TraineeId = 22, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 23, CourseId = 1, TraineeId = 23, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 24, CourseId = 1, TraineeId = 24, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 25, CourseId = 1, TraineeId = 25, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 26, CourseId = 1, TraineeId = 26, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 27, CourseId = 1, TraineeId = 27, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 28, CourseId = 1, TraineeId = 28, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 29, CourseId = 1, TraineeId = 29, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 30, CourseId = 1, TraineeId = 30, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 31, CourseId = 2, TraineeId = 1, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 32, CourseId = 2, TraineeId = 2, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 33, CourseId = 2, TraineeId = 3, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 34, CourseId = 2, TraineeId = 4, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 35, CourseId = 2, TraineeId = 5, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 36, CourseId = 2, TraineeId = 6, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 37, CourseId = 2, TraineeId = 7, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 38, CourseId = 2, TraineeId = 8, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 39, CourseId = 2, TraineeId = 9, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 40, CourseId = 2, TraineeId = 10, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 41, CourseId = 2, TraineeId = 11, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 42, CourseId = 2, TraineeId = 12, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 43, CourseId = 2, TraineeId = 13, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 44, CourseId = 2, TraineeId = 14, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 45, CourseId = 2, TraineeId = 15, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 46, CourseId = 2, TraineeId = 16, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 47, CourseId = 2, TraineeId = 17, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 48, CourseId = 2, TraineeId = 18, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 49, CourseId = 2, TraineeId = 19, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 50, CourseId = 2, TraineeId = 20, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 51, CourseId = 2, TraineeId = 21, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 52, CourseId = 2, TraineeId = 22, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 53, CourseId = 2, TraineeId = 23, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 54, CourseId = 2, TraineeId = 24, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 55, CourseId = 2, TraineeId = 25, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 56, CourseId = 2, TraineeId = 26, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 57, CourseId = 2, TraineeId = 27, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 58, CourseId = 2, TraineeId = 28, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 59, CourseId = 2, TraineeId = 29, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 60, CourseId = 2, TraineeId = 30, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 61, CourseId = 3, TraineeId = 1, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 62, CourseId = 3, TraineeId = 2, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 63, CourseId = 3, TraineeId = 3, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 64, CourseId = 3, TraineeId = 4, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 65, CourseId = 3, TraineeId = 5, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 66, CourseId = 3, TraineeId = 6, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 67, CourseId = 3, TraineeId = 7, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 68, CourseId = 3, TraineeId = 8, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 69, CourseId = 3, TraineeId = 9, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 70, CourseId = 3, TraineeId = 10, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 71, CourseId = 3, TraineeId = 11, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 72, CourseId = 3, TraineeId = 12, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 73, CourseId = 3, TraineeId = 13, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 74, CourseId = 3, TraineeId = 14, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 75, CourseId = 3, TraineeId = 15, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 76, CourseId = 3, TraineeId = 16, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 77, CourseId = 3, TraineeId = 17, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 78, CourseId = 3, TraineeId = 18, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 79, CourseId = 3, TraineeId = 19, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 80, CourseId = 3, TraineeId = 20, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 81, CourseId = 3, TraineeId = 21, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 82, CourseId = 3, TraineeId = 22, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 83, CourseId = 3, TraineeId = 23, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 84, CourseId = 3, TraineeId = 24, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 85, CourseId = 3, TraineeId = 25, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 86, CourseId = 3, TraineeId = 26, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 87, CourseId = 3, TraineeId = 27, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 88, CourseId = 3, TraineeId = 28, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 89, CourseId = 3, TraineeId = 29, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 91, CourseId = 3, TraineeId = 31, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 92, CourseId = 3, TraineeId = 32, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 93, CourseId = 3, TraineeId = 33, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 94, CourseId = 4, TraineeId = 1, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 95, CourseId = 4, TraineeId = 2, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 96, CourseId = 4, TraineeId = 3, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 97, CourseId = 4, TraineeId = 4, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 98, CourseId = 4, TraineeId = 5, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 99, CourseId = 4, TraineeId = 6, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
        new CourseTrainee { Id = 100, CourseId = 4, TraineeId = 7, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
                new CourseTrainee { Id = 101, CourseId = 1, TraineeId = 31, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
                new CourseTrainee { Id = 102, CourseId = 1, TraineeId = 32, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) },
                new CourseTrainee { Id = 103, CourseId = 1, TraineeId = 33, Points = random2.Next(0, 101) * 10, Result = (decimal)(random2.NextDouble() * 100) }
            );
        }

    }
}


