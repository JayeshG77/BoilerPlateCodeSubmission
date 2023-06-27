using MediatR;
using MediatRsession3.Models;

namespace MediatRsession3.Data.Command
{
    public class UpdateProductCommand:IRequest<int>
    {
     

        public UpdateProductCommand(int id,string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        
    }
}
