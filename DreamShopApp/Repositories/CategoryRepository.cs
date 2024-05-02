using DreamShopApp.Data;
using DreamShopApp.Interfaces;
using DreamShopApp.Models;
namespace DreamShopApp.Repositories
{
    public class CategoryRepository:ICategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public ICollection<Category> GetAllCategories()
        {
            return _context.Categories.OrderBy(c => c.Name).ToList();
        }
        public Category GetCategoryDetails(int id)
        {
            return _context.Categories.Where(c=>c.Id==id).FirstOrDefault();
        }

    }
}
