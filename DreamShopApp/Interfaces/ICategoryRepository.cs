using DreamShopApp.Models;
namespace DreamShopApp.Interfaces
    
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetAllCategories();
        Category GetCategoryDetails(int id);
        Category GetCategoryDetails(string name);
    }
}
