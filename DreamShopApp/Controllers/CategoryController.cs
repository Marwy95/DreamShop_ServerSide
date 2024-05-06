using DreamShopApp.Dtos.Category;
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
        [Route("getAllCategories")]
     
        public IActionResult Get()
        {
            var Categories = _categoryRepository.GetAllCategories();
            if (Categories == null) return NotFound();
            return Ok(Categories) ;
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var Category = _categoryRepository.GetCategoryById(id);
                return Ok(Category);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }
        [HttpPost]
        [Route("addCategory")]
        public IActionResult Add([FromBody] CreateCategoryDto createCategoryDto)
        {
            _categoryRepository.AddCategory(createCategoryDto);
            return Ok();
        }
    }
}
