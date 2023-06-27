using MediatR;
using MediatRsession3.Data;
using MediatRsession3.Services;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace MediatRsession3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            string con = builder.Configuration.GetConnectionString("localString");
            builder.Services.AddDbContext<AppDbContext>(op => op.UseSqlServer(con));
            builder.Services.AddScoped<IProductService, ProductService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}