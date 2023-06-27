using MediatR;
using MediatRsession3.Models;

namespace MediatRsession3.Data.Command
{
    public class CreateProductCommand : IRequest<Product>
    {
        public CreateProductCommand(string name, int price)
        {
            Name = name;
            Price = price;
        }



        public string Name { get; set; }
        public int Price { get; set; }

    }
}
