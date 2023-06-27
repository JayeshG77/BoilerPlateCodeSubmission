using MediatR;
using MediatRsession3.Data.Command;
using MediatRsession3.Models;
using MediatRsession3.Services;

namespace MediatRsession3.Data.Handlers
{
    public class CreateProductHandler:IRequestHandler<CreateProductCommand, Product>
    {
        readonly IProductService _productService;

        public CreateProductHandler(IProductService productService)
        {
                _productService = productService;
        }

        public async Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            Product p = new Product
            {
                Name = request.Name,
                Price = request.Price,
            };
            return await _productService.AddProduct(p);
        }
    }
}
