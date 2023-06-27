using System.ComponentModel.DataAnnotations;

namespace Session2.Models
{
    public class Product
    {
        //define table and column names
        [Key]
        public int ProductId { get; set; }
        //[Required]
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }
   

    }
}
