using MediatR;
using MediatRsession3.Data;
using MediatRsession3.Data.Command;
using MediatRsession3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MediatRsession3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IMediator _mediator;

        public ProductController(IMediator mediator)
        {
                _mediator= mediator;
        }
       
        [HttpGet]
        public async Task<List<Product>> ProductList()
        {
            return await _mediator.Send(new GetProductListQuery());
        }

        [HttpGet("{id}")]
        public async Task<Product> ProductByid(int id)
        {
            return await _mediator.Send(new GetProductByIdQuery() { Id=id});
        }

        [HttpPost]
        public async Task<Product> AddProduct(Product product)
        {
            return await _mediator.Send(new CreateProductCommand(product.Name, (int)product.Price));
        }

        [HttpPut]
        public async Task<int> UpdateProduct(Product product)
        {
            return await _mediator.Send(new UpdateProductCommand(product.Id,product.Name, (int)product.Price));
        }

        [HttpDelete("{id}")]
        public async Task<int> DeleteProduct(int id)
        {
            return await _mediator.Send(new DeleteProductCommand() { Id=id});
        }
    }
}
