using System.ComponentModel.DataAnnotations;

namespace Session2.ModeView
{
    public class ShowProductVm
    {
        
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
