using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Session4.Configuration;
using Session4.Model;

namespace Session4.Context
{
    public class AppDbContext:DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> context):base(context)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ProductConfig());
        }
        public DbSet<Product> Products { get; set; }
    }
}
