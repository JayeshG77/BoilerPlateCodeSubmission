using MediatR;
using MediatRsession3.Models;

namespace MediatRsession3.Data
{
    public class GetProductByIdQuery:IRequest<Product>
    {
        public int Id { get; set; }
    }
}
