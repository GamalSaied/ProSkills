using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProSkills.Models.ClientSide;

namespace ProSkills.Models
{
   
    public class ITIContext : IdentityDbContext<ApplicationUser>
    {

        //foreach model make a dbset because this will transform into tables
        public DbSet<Trainee> Trainee { get; set; }
        public DbSet<Course> Course { get; set; }
        //public DbSet<CrsResult> CrsResult { get; set; }

        public ITIContext(DbContextOptions<ITIContext> options) : base(options) //injection
        {

        }


        //const string connectionstring = "Server=.; Database=ITIAEC_InstructorsDB; Trusted_Connection=True; Encrypt=false;";
        //const string connectionstring = "Data Source=.;Initial Catalog = ITIAEC44_InstructorDB; Integrated Security = True; Encrypt=false;";
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(connectionstring);


        //}
        //seeding for data
        //this statment will transform into select query

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //this statment will transform into select query
            modelBuilder.Entity<Course>().HasData(new Course { Id = 1, Name = "Mearn" ,Hours = 30 });
            modelBuilder.Entity<Course>().HasData(new Course { Id = 2, Name = "clean code", Hours = 70 });
            modelBuilder.Entity<Course>().HasData(new Course { Id = 3, Name = "OOP", Hours= 50 });

         


            //////////////seeding for trainee
            modelBuilder.Entity<Trainee>().HasData(new Trainee { Id = 1, Name = "Gamal",CourseId=2 });
            modelBuilder.Entity<Trainee>().HasData(new Trainee { Id = 2, Name = "amr", CourseId = 1 });
            modelBuilder.Entity<Trainee>().HasData(new Trainee { Id = 3, Name = "mosalah", CourseId = 3 });
            modelBuilder.Entity<Trainee>().HasData(new Trainee { Id = 4, Name = "ramie", CourseId = 3 });
            modelBuilder.Entity<Trainee>().HasData(new Trainee { Id = 5, Name = "awwad", CourseId = 2 });
            modelBuilder.Entity<Trainee>().HasData(new Trainee { Id = 6, Name = "sadat", CourseId = 2 });
            modelBuilder.Entity<Trainee>().HasData(new Trainee { Id = 7, Name = "mora", CourseId = 1 });
            modelBuilder.Entity<Trainee>().HasData(new Trainee { Id = 8, Name = "safaa", CourseId = 1 });

            //seeding for department

            base.OnModelCreating(modelBuilder);
        }

    }
}

