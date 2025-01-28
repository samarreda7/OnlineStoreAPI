using Microsoft.AspNetCore.Mvc;
using OnlineStoreAPI.DTO;
using OnlineStoreAPI.Models;

namespace OnlineStoreAPI.Repository
{
    public interface IproductRepository
    {
        public List<Product> GetAll();
        public void AddProduct(Product prod);

        public Product GetById(int id);
        public void UpdateProduct(Product Pro);

        public void DeletePproduct(Product prod);

        public void Save();
        
    }
}
