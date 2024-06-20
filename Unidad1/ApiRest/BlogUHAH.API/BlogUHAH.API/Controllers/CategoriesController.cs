using BlogUHAH.API.Database.Entities;
using BlogUHAH.API.Dtos.Categories;
using BlogUHAH.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogUHAH.API.Controllers
{
    [ApiController]
    [Route("api/categories")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriesService _categoriesService;

        public List<Category> _categories { get; set; }

        public CategoriesController(ICategoriesService categoriesService)
        {
            this._categoriesService = categoriesService;    
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() 
        { 
            return Ok(await _categoriesService.GetCategoriesListAsync());
        }

        [HttpGet("{id}")]

        public async Task<ActionResult> Get(Guid id)
        {

            var category = await _categoriesService.GetCategoryByIdAsync(id);

            if (category == null)
            {
                return NotFound(new { Message = $"No se encontro la categoria: {id}" });
            }

            return Ok(category);
        }

        [HttpPost]
        public async Task<ActionResult> Create(CategoryCreateDto dto)
        {

            await _categoriesService.CreateAsync(dto);

            return StatusCode(201);
        }

        [HttpPut("{id}")]

        public async Task<ActionResult> Edit(CategoryEditDto dto, Guid id)
        {
            var result = await _categoriesService.EditAsync(dto, id);
            if (!result) 
            {
                return NotFound();
            }

            return Ok();
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult> Delete(Guid id)
        {
            var category = await _categoriesService.GetCategoryByIdAsync(id);

            if (category is null)
            {
                return NotFound();
            }

            await _categoriesService.DeleteAsync(id);

            return Ok();
        }

    }
}




