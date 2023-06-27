using Microsoft.EntityFrameworkCore;
using Session2.Models;
using Session2.ModeView;
using System.Data.Common;

namespace Session2.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> Context) : base(Context)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ShowProductVm>().HasNoKey();
        }
        //create table
        public DbSet<Product> Products { get; set; }
    }
}
