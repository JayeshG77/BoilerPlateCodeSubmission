using MediatRsession3.Models;
using Microsoft.EntityFrameworkCore;

namespace MediatRsession3.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> context):base(context) 
        {

        }
        public DbSet<Product> Products { get; set; }    
    }
}
