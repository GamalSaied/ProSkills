using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProSkills.Models.AdminPanel.Instractor;
using ProSkills.Models.ClientSide;

namespace ProSkills.Models
{
   
    public class ITIContext : IdentityDbContext<ApplicationUser>
    {
        // 1- Create Database Tables 
        // ====> DbSet<Class> TableName   
        public DbSet<instructor> instructor { get; set; }

        // --------------------------------------------------------------------
        // 2- Restore Constractor from Parent DBContext
        public ITIContext() : base()
        { }

        // 3- Override OnConfigruing --> Ba3mil Connect 3la elDataBase
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //DbCotnext Option 4
            optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=DBaseAECI;Integrated Security=True;Encrypt=False");//ConnectString
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

            base.OnModelCreating(modelBuilder);
        }

        ////foreach model make a dbset because this will transform into tables
        //public DbSet<Trainee> Trainee { get; set; }
        //public DbSet<Course> Course { get; set; }
        //public DbSet<instructor> instructor { get; set; }
        ////public DbSet<CrsResult> CrsResult { get; set; }

        //public ITIContext(DbContextOptions<ITIContext> options) : base(options) //injection
        //{

        //}


        //const string connectionstring = "Server=.; Database=ITIAEC_InstructorsDB; Trusted_Connection=True; Encrypt=false;";
        //const string connectionstring = "Data Source=.;Initial Catalog = ITIAEC44_InstructorDB; Integrated Security = True; Encrypt=false;";
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(connectionstring);


        //}
        //seeding for data
        //this statment will transform into select query

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //this statment will transform into select query
        //    modelBuilder.Entity<Course>().HasData(new Course { Id = 1, Name = "Mearn" ,Hours = 30 });
        //    modelBuilder.Entity<Course>().HasData(new Course { Id = 2, Name = "clean code", Hours = 70 });
        //    modelBuilder.Entity<Course>().HasData(new Course { Id = 3, Name = "OOP", Hours= 50 });




        //    //////////////seeding for trainee
        //    modelBuilder.Entity<Trainee>().HasData(new Trainee { Id = 1, Name = "Gamal",CourseId=2 });
        //    modelBuilder.Entity<Trainee>().HasData(new Trainee { Id = 2, Name = "amr", CourseId = 1 });
        //    modelBuilder.Entity<Trainee>().HasData(new Trainee { Id = 3, Name = "mosalah", CourseId = 3 });
        //    modelBuilder.Entity<Trainee>().HasData(new Trainee { Id = 4, Name = "ramie", CourseId = 3 });
        //    modelBuilder.Entity<Trainee>().HasData(new Trainee { Id = 5, Name = "awwad", CourseId = 2 });
        //    modelBuilder.Entity<Trainee>().HasData(new Trainee { Id = 6, Name = "sadat", CourseId = 2 });
        //    modelBuilder.Entity<Trainee>().HasData(new Trainee { Id = 7, Name = "mora", CourseId = 1 });
        //    modelBuilder.Entity<Trainee>().HasData(new Trainee { Id = 8, Name = "safaa", CourseId = 1 });


        //    //////////////seeding for instractor  
        //    


        //    //seeding for department

            //base.OnModelCreating(modelBuilder);
    }




}


