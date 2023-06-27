using MediatR;
using MediatRsession3.Models;

namespace MediatRsession3.Data
{
    public class GetProductListQuery:IRequest<List<Product>>
    {
    }
}
