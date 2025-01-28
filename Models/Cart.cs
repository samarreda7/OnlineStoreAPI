using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStoreAPI.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("User")]
        public int  UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public User User { get; set; }
    }
}
