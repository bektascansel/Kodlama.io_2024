using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Entities.Concrete.Dto.CategoryDtos;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {

            var values = _categoryService.GetAll();
            return Ok(values);

        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            var value = _categoryService.Get(id);
            return Ok(value);

        }


        [HttpPost("createCategory")]
        public IActionResult CreateCategory(CreateCategoryDto categoryDto)
        {

            _categoryService.Create(categoryDto);
            return Ok("Category Created");

        }


        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {

            _categoryService.Delete(id);
            return Ok("Category Deleted");

        }

        [HttpPut("updateCategory")]
        public IActionResult UpdateCategory(UpdateCategoryDto category)
        {

            _categoryService.Update(category);
            return Ok("Category Updated");

        }
    }
}
