using MediatR;
using MediatRsession3.Models;
using MediatRsession3.Services;

namespace MediatRsession3.Data.Handlers
{
    public class GetProductListHandler : IRequestHandler<GetProductListQuery, List<Product>>
    {
        readonly IProductService _productService;
        public GetProductListHandler(IProductService productService)
        {
                _productService = productService;
        }

        public async Task<List<Product>> Handle(GetProductListQuery request, CancellationToken cancellationToken)
        {
            return await _productService.GetProductList();
        }
    }
}
