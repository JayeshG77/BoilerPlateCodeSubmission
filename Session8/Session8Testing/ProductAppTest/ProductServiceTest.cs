using MediatRsession3.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MediatRsession3.Models;
//writing test cases for service layer
namespace ProductAppTest
{
    //Iclassfixture->initialize productAppdbfixture before running test class
    public class ProductServiceTest:IClassFixture<ProductAppDbFixture>
    {
        //internally Productservice contacting database layer
        readonly ProductService _productService;
        //ctor ->pass inmemory DbFixture
        public ProductServiceTest(ProductAppDbFixture productAppDbFixture)
        {
            _productService = new ProductService(productAppDbFixture._appDbContext);
        }

        

        [Fact]
        public async Task GetAllProductListTest()
        {
            // Arrange
             
            // Act
            var products = await _productService.GetProductList();

            // Assert
            Assert.NotNull(products);
            Assert.IsType<List<Product>>(products);
            Assert.NotEmpty(products);


        }

        [Fact]
        public async void AddProductTest()
        {
            //Assign
            string expectedProductName = "Printer";

            //Act-->Call Devlopment code
            _productService.AddProduct(new Product() { Id = 5, Name = "Printer", Price = 14999 });

            List<Product> products =await _productService.GetProductList();

            var actualProductName = products[4].Name;           

            //Assert
            Assert.Equal(expectedProductName, actualProductName);
        }

        //[Fact]
        //public async void DeleteProductTest()
        //{
        //    //Assign
        //    List<Product> products = await _productService.GetProductList();

        //    //Act
        //    _productService.DeleteProduct(products[0].Id);
            

        //    //Asert
            
        //}   



    }
}
