using Session2.Models;

namespace Session2.Service
{
    public interface IProductService
    {
        public void AddProduct(Product product);
        void DeleteProduct(Product product);
        void EditProduct(Product product);
        Product GetProductById(int id);
        public List<Product> ShowProducts();
    }
}
