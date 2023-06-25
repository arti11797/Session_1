using Session_1.Interface;
using Session_1.Services;

namespace EmployeeManage_1._2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IServices, Service>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();


            app.UseEndpoints(endpoints => {

                endpoints.MapControllerRoute(
                        name: "default",
                    pattern: "{controller=Service}/{action=Index}");

            });

            app.Run();
        }
    }
    
}