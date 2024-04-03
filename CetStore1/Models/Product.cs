using System.ComponentModel.DataAnnotations;

namespace CetStore1.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(500)]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Html)]
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockCount { get; set; }


        public int? CategoryId { get; set; }
        public virtual Category? Category { get; set; }
    }
}
