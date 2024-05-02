using DreamShopApp.Interfaces;
using DreamShopApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DreamShopApp.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CategoryController:ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        [HttpGet]
        //[ProducesResponseType(200,Type=typeof(IEnumerable<Category>))]
        public IActionResult Get()
        {
            var Categories = _categoryRepository.GetAllCategories();
            return Ok(Categories) ;
        }
    }
}
