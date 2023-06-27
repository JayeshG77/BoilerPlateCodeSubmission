using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Session2.Configurations;
using Session2.Context;
using Session2.Repository;
using Session2.Service;

namespace Session2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            String con = builder.Configuration.GetConnectionString("localString");
            builder.Services.AddDbContext<AppDbContext>(p => p.UseSqlServer(con));
            builder.Services.AddScoped<IProductRepository , ProductRepository>();
            builder.Services.AddScoped<IProductService , ProductService>();
            builder.Services.AddAutoMapper(typeof(MapperConfigurations));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
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