using DreamShopApp.Dtos.Category;
using DreamShopApp.Models;
namespace DreamShopApp.Interfaces
    
{
    public interface ICategoryRepository
    {
       
        ICollection<CategoryDto > GetAllCategories();
        void AddCategory(CreateCategoryDto createCategoryDto);
        CategoryDto GetCategoryById(int categoryId);
        //Category GetCategoryDetails(string name);
    }
}
