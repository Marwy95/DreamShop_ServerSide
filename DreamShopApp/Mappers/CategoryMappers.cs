using DreamShopApp.Dtos.Category;
using DreamShopApp.Models;
using Microsoft.AspNetCore.Server.IIS.Core;
using System.Runtime.CompilerServices;

namespace DreamShopApp.Mappers
{
    public static class CategoryMappers
    {
        public static CategoryDto ToCategoryDto(this Category categoryModel)
        {
                return new CategoryDto
                {
                    Id = categoryModel.Id,
                    Name = categoryModel.Name
                };
            
           
        }
        public static Category ToCategoryFromCreateCategoryDto(this CreateCategoryDto createCategoryDto)
        {
            return new Category
            {
                Name = createCategoryDto.Name,
            };
        }
    }
}
