using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using ProSkills.Controllers;
using ProSkills.Interfaces;
using ProSkills.Models;
using ProSkills.Models.AdminPanel.InstructorManger;
using ProSkills.Models.ClientSide;
using ProSkills.Repository;

namespace ProSkills
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();



            builder.Services.AddIdentity<ApplicationUser, IdentityRole>(
       options =>
       {
           options.Password.RequiredLength = 4;
           options.Password.RequireNonAlphanumeric = false;
           options.Password.RequireDigit = false;
           options.Password.RequireUppercase = false;

       }).AddEntityFrameworkStores<ITIContext>().AddDefaultTokenProviders();


            //to change the session time
            builder.Services.AddSession(
                Options =>
                {
                    Options.IdleTimeout = TimeSpan.FromMinutes(5);   //change session time out
                }

                ); //add settings  we should put it before builder

         


            builder.Services.AddDbContext<ITIContext>(
                Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("cs")));


            //where users are redirected when they are not authenticated. In this case, if an unauthenticated user tries to
            //access a protected resource, they will be redirected to the "Account/login" page.
            //redirected when they do not have permission to access a resource (authorization failure) => "Home/Error".
            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(Options =>
            {
                Options.LoginPath = "/Account/Login";
                Options.LogoutPath = "/Account/logout";
                Options.AccessDeniedPath = "/Home/Error";
            });



            //inject dbcontext options //inject iticontext
            //register 
            builder.Services.AddScoped<IRepository<instructor>, InstructorRepository>();
            builder.Services.AddScoped<IRepository<Category>, CategoryRepository>();
            builder.Services.AddScoped<IRepository<Course>, CourseRepository>();

            builder.Services.AddScoped<IRepository<Package>, PackageRepository>();
            builder.Services.AddScoped<IRepository<RedeemCode>, RedeemCodeRepository>();
            //builder.Services.AddScoped<IRepository, CourseRepository>();
            //builder.Services.AddScoped<ICourseRepository, CourseRepository>();
            //builder.Services.AddScoped<ITraineeRepository, TraineeRepository>();
            // Add services to the container.

            var app = builder.Build();

            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NBaF5cXmZCe0x3RHxbf1x0ZFdMYF5bR3dPMyBoS35RckVmWXtecnRXRWFbVkF/");

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
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