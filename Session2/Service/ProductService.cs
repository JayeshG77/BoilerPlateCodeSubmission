using Microsoft.AspNetCore.Mvc;
using Session2.Models;
using Session2.Repository;

namespace Session2.Service
{
    public class ProductService : IProductService
    {
        readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
              _productRepository = productRepository;
        }


        public void AddProduct(Product product)
        {
            _productRepository.AddProduct(product);
        }

        public void DeleteProduct(Product product)
        {
            _productRepository.DeletetProduct(product);
        }

        public void EditProduct(Product product)
        {
            _productRepository.EditProduct(product);
        }

        public Product GetProductById(int id)
        {
            return _productRepository.GetProductById(id);
        }

        public List<Product> ShowProducts()
        {
            return _productRepository.ShowProducts();
        }
    }
}
