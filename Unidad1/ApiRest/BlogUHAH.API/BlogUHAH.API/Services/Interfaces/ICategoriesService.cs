using BlogUHAH.API.Database.Entities;
using BlogUHAH.API.Dtos;
using BlogUHAH.API.Dtos.Categories;

namespace BlogUHAH.API.Services.Interfaces
{
    public interface ICategoriesService
    {
        Task<List<CategoryDto>> GetCategoriesListAsync();
        Task<CategoryDto> GetCategoryByIdAsync(Guid id);
        Task<bool> CreateAsync(CategoryCreateDto dto);
        Task<bool> EditAsync(CategoryEditDto dto, Guid id);
        Task<bool> DeleteAsync(Guid id);

    }
}
