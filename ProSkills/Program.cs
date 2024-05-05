using ProSkills.Models;

namespace ProSkills
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            //to change the session time
            builder.Services.AddSession(
                Options =>
                {
                    Options.IdleTimeout = TimeSpan.FromMinutes(5);   //change session time out
                }

                ); //add settings  we should put it before builder

            ////inject dbcontext options //nject iticontext
            //builder.Services.AddDbContext<ITIContext>(
            //    Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("cs")));

            // Add services to the container.

            var app = builder.Build();

            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NBaF5cXmZCe0x3RHxbf1x0ZFdMYF5bR3dPMyBoS35RckVmWXtecnRXRWFbVkF/");

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}