using OnlineStoreAPI.Models;

namespace OnlineStoreAPI.Repository
{
    public interface IcategoryRepository
    {
        public List<Category> GetAll();
        public Category GetById(int id);
        public void AddCategory(Category catg);
        public void UpdateCategory(Category catg);
        public void DeleteCategory(Category catg);
        public void Save();
    }
}
