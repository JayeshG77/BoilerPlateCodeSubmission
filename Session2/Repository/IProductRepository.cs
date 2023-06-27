using Session2.Models;

namespace Session2.Repository
{
    public interface IProductRepository
    {
        public void AddProduct(Product product);
        void DeletetProduct(Product product);
        void EditProduct(Product product);
        Product GetProductById(int id);
        public List<Product> ShowProducts();
    }
}
