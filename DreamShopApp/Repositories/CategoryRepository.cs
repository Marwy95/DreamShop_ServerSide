using DreamShopApp.Data;
using DreamShopApp.Dtos.Category;
using DreamShopApp.Interfaces;
using DreamShopApp.Mappers;
using DreamShopApp.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace DreamShopApp.Repositories
{
    public class CategoryRepository:ICategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public ICollection<CategoryDto> GetAllCategories()
        {
            return _context.Categories.Select(c => c.ToCategoryDto()).ToList();
          
        }
        public void AddCategory(CreateCategoryDto createCategoryDto)
        {
            //var categorymodel = ;
            _context.Categories.Add(createCategoryDto.ToCategoryFromCreateCategoryDto());
            _context.SaveChanges();
        }
        public CategoryDto GetCategoryById(int categoryId)
        {
            var category = _context.Categories.Find(categoryId);
            if(category == null) throw new Exception("invalid id");

            return category.ToCategoryDto();
            
           
            
        }

       
    }
}
