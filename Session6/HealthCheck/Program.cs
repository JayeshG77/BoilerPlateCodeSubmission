using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.EntityFrameworkCore;
using Session4.Context;
using Session4.HealthCheck;

namespace Session4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            string conection = builder.Configuration.GetConnectionString("localString");
            builder.Services.AddDbContext<AppDbContext>(p=>p.UseSqlServer(conection));
            builder.Services.AddHealthChecks().AddSqlServer(conection).AddCheck<GetAllProductHealthCheck>("GetAllProductCheck");
            builder.Services.AddHealthChecksUI().AddInMemoryStorage();

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
            app.MapHealthChecks("/healthchecks", new HealthCheckOptions
            {
                ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
            });
            app.MapHealthChecksUI();

            app.Run();
        }
    }
}