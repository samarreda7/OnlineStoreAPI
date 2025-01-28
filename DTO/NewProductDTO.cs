using OnlineStoreAPI.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStoreAPI.DTO
{
    public class NewProductDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int stockQuantity { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreatedAt { get; set; }

        public Category Category { get; set; }
    }
}
