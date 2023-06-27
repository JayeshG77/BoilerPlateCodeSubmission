using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session4.Model;
using System.Xml.Linq;

namespace Session4.Configuration
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name= "Product-1",
                    Price=100
                },
                new Product 

                {
                    Id = 2,
                    Name = "Product-2",
                    Price = 200
                },
                new Product
                {
                    Id = 3,
                    Name = "Product-3",
                    Price = 300
                }
                );
        }
    }
}
