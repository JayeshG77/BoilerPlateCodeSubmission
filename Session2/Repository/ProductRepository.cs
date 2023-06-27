using Microsoft.EntityFrameworkCore;
using Session2.Context;
using Session2.Models;

namespace Session2.Repository
{
    public class ProductRepository:IProductRepository
    {
         readonly AppDbContext _dbContext;

        public ProductRepository(AppDbContext dbContext)
        {
                _dbContext = dbContext;
        }

        public void AddProduct(Product product)
        {
            _dbContext.Add<Product>(product);
            _dbContext.SaveChanges();
        }

        public void DeletetProduct(Product product)
        {
            ; ; ; ; ; ;
            _dbContext.Products.Remove(product);
            _dbContext.SaveChanges();
        }

        public void EditProduct(Product product)
        {
           var prod= _dbContext.Products.FirstOrDefault(u=> u.ProductId == product.ProductId);
            if (prod != null)
            {
                //prod.ProductId = product.ProductId;
                prod.ProductName= product.ProductName;
                prod.ProductPrice= product.ProductPrice;
                prod.Quantity= product.Quantity;

            }
            _dbContext.SaveChanges();
        }

        public Product GetProductById(int id)
        {
            return _dbContext.Find<Product>(id);
        }

        public List<Product> ShowProducts()
        {
            return _dbContext.Products.ToList();
        }
    }
}
