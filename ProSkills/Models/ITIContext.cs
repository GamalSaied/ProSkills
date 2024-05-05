using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProSkills.Models.ClientSide;

namespace ProSkills.Models
{
    public class ITIContext: IdentityDbContext<ApplicationUser>
    {

        //foreach model make a dbset because this will transform into tables
        public DbSet<Trainee> Trainee { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<CrsResult> CrsResult { get; set; }

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


            //seeding for department
            modelBuilder.Entity<Trainee>().HasData(new Trainee { Id = 1, Name = "Ahmed"});
            modelBuilder.Entity<Trainee>().HasData(new Trainee { Id = 2, Name = "Gamal" });
            modelBuilder.Entity<Trainee>().HasData(new Trainee { Id = 3, Name = "Sadat"});


            base.OnModelCreating(modelBuilder);
        }

    }
}

