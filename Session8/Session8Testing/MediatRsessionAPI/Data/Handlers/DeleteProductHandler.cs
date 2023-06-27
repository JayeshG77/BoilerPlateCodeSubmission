using MediatR;
using MediatRsession3.Data.Command;
using MediatRsession3.Services;

namespace MediatRsession3.Data.Handlers
{
    public class DeleteProductHandler : IRequestHandler<DeleteProductCommand, int>
    {
        readonly IProductService _productService;
        public DeleteProductHandler(IProductService productService)
        {
            _productService = productService;   
        }
        public async Task<int> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _productService.GetProductById(request.Id);
            if (product == null) { return default; }
            return await _productService.DeleteProduct(request.Id);
        }
    }
}
