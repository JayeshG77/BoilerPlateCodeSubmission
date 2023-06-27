using MediatRsession3.Models;

namespace MediatRsession3.Services
{
    public interface IProductService
    {
        public Task<List<Product>> GetProductList();
        public Task<Product> GetProductById(int id);
        public Task<Product> AddProduct(Product product);
        public Task<int> UpdateProduct(Product product);
        public Task<int> DeleteProduct(int id);
    }
}
