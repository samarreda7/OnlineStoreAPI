using Microsoft.Identity.Client;
using OnlineStoreAPI.Models;

namespace OnlineStoreAPI.Repository
{
    public class ProductReprository : IproductRepository
    {
        private readonly OnlineStoreContext context;
        public ProductReprository( OnlineStoreContext _context)
        {
            context = _context;
        }
         public List<Product> GetAll()
        {
            return context.Products.ToList();
        }
        public void AddProduct(Product prod)
        {
            context.Products.Add(prod);
        }

          public Product GetById(int id)
        {
            return context.Products.First(p => p.Id == id);
        }

        public void UpdateProduct(Product prod)
        {
            context.Update(prod);
        }
        public void DeletePproduct(Product prod)
        {
            context.Remove(prod);
        }
        public void Save()
        {
            context.SaveChanges();
        }

      
    }
}
