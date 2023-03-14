using Microsoft.EntityFrameworkCore;
using MVCProject.Models;
using MVCProject.Repository;

namespace MVCProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            // injection
            builder.Services.AddDbContext<Context>(option =>
            {
                option.UseSqlServer(builder.Configuration.GetConnectionString("DB"));
            });

            builder.Services.AddScoped<IProductRepository, ProductRepository>();//register 

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}