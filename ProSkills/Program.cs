using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProSkills.Interfaces;
using ProSkills.Models;
using ProSkills.Models.ClientSide;
using ProSkills.Repositories;
using ProSkills.Repository;

namespace ProSkills
{
    public class Program
    {
      
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<ITIContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("cs")));

            builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 4;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireUppercase = false;
            }).AddEntityFrameworkStores<ITIContext>().AddDefaultTokenProviders();

            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(5);
            });

           

            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
                options.LoginPath = "/Account/Login";
                options.LogoutPath = "/Account/Logout";
                options.AccessDeniedPath = "/Home/Error";
            });

            // Register repositories
            builder.Services.AddScoped<IRepository<instructor>, InstructorRepository>();
            builder.Services.AddScoped<IRepository<Category>, CategoryRepository>();
            builder.Services.AddScoped<IRepository<Course>, CourseRepository>();
            builder.Services.AddScoped<IRepository<Trainee>, TraineeRepository>();
            builder.Services.AddScoped<IRepository<Package>, PackageRepository>();
            builder.Services.AddScoped<IRepository<RedeemCode>, RedeemCodeRepository>();
            builder.Services.AddScoped<IRepository<Lesson>, LessonRepository>();
            builder.Services.AddScoped<IRepository<Chapter>, ChapterRepository>();
            builder.Services.AddScoped<ICourseRepository, CourseRepository>();
            builder.Services.AddScoped<ITraineeRepository, TraineeRepository>();
            builder.Services.AddScoped<IRepository<Service>, ServiceRepository>();
            builder.Services.AddScoped<ICourseTraineeRepository, CourseTraineeRepository>();
            builder.Services.AddScoped<IRepository<Assessment>, AssessmentRepository>();
            builder.Services.AddScoped<IActivityLogRepository, ActivityLogRepository>();
            builder.Services.AddScoped<IJoinRequestRepository, JoinRequestRepository>();



            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseSession();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}");

            app.Run();
        }
    }
}
