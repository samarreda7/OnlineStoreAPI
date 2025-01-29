using OnlineStoreAPI.Models;

namespace OnlineStoreAPI.Repository
{
    public class CategoryRepository : IcategoryRepository
    {
        private readonly OnlineStoreContext context;
        public CategoryRepository(OnlineStoreContext _context)
        {
            context = _context;
        }

        public List<Category> GetAll()
        {
           return context.Categories.ToList();
        }
        public Category GetById(int id)
        {
            Category catg = context.Categories.FirstOrDefault(c => c.Id == id);
            return catg;
        }
        public void AddCategory(Category catg)
        {
            context.Categories.Add(catg);
        }

        public void DeleteCategory(Category catg)
        {
            context.Categories.Remove(catg);
        }


        public void UpdateCategory(Category catg)
        {
            context.Update(catg);

        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
