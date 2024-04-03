using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CetStore1.Models
{
    public class Category
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public virtual List<Product> Products { get; set; } = new List<Product>();
    }
}
