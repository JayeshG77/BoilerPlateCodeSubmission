using MediatR;
using System.Security.Cryptography.X509Certificates;

namespace MediatRsession3.Data.Command
{
    public class DeleteProductCommand:IRequest<int>
    {
        public int Id { get; set; }
    }
}
