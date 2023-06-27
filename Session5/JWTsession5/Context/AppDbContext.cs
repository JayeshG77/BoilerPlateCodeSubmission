using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Session4.Configuration;
using Session4.Model;
using Session5.Configuration;
using Session5.Model;

namespace Session4.Context
{
    public class AppDbContext:IdentityDbContext<User>

    {
        public AppDbContext(DbContextOptions<AppDbContext> context):base(context)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }
        public DbSet<Product> Products { get; set; }
    }
}
