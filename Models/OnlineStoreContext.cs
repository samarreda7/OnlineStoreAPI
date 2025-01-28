using Microsoft.EntityFrameworkCore;

namespace OnlineStoreAPI.Models
{
    public class OnlineStoreContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
       public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; } 
        
        public DbSet<User> Users { get; set; }
        public OnlineStoreContext(DbContextOptions<OnlineStoreContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Ignore(e => e.Category);
        }


    }


}
