using MediatR;
using MediatRsession3.Data.Command;
using MediatRsession3.Services;

namespace MediatRsession3.Data.Handlers
{
    public class updateProductHandler : IRequestHandler<UpdateProductCommand, int>
    {
        readonly IProductService _productService;
        public updateProductHandler(IProductService productService)
        {
                _productService = productService;
        }
        public async Task<int> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _productService.GetProductById(request.Id);
            if (product == null)
                {
                return default;
                }

            product.Name = request.Name;
            product.Price = request.Price;
            return await _productService.UpdateProduct(product);
        }
    }
}
