using MediatRsession3.Data;
using MediatRsession3.Models;
using Microsoft.EntityFrameworkCore;

namespace MediatRsession3.Services
{
    public class ProductService : IProductService
    {
        readonly AppDbContext _dbContext;
        public ProductService(AppDbContext dbContext)
        {
                _dbContext = dbContext; 
        }
        public async Task<Product> AddProduct(Product product)
        {
            var result = _dbContext.Products.Add(product);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
          
        }

        public async Task<int> DeleteProduct(int id)
        {
            var product = _dbContext.Products.Where(x=>x.Id == id).FirstOrDefault();    
            _dbContext.Products.Remove(product);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            var product = _dbContext.Products.Where(x => x.Id == id).FirstOrDefault();
            return product;
        }

        public async Task<List<Product>> GetProductList()
        {
            return await _dbContext.Products.ToListAsync();
        }

        public async Task<int> UpdateProduct(Product product)
        {
             _dbContext.Products.Update(product);
            //var prod =  _dbContext.Products.FirstOrDefault(u => u.Id == product.Id);
            //if (prod != null)
            //{
            //    //prod.ProductId = product.ProductId;
            //    prod.Name = product.Name;
            //    prod.Price = product.Price;
            //}
            return _dbContext.SaveChanges();
        }
    }
}

