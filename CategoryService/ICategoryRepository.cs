using CategoryService.Model;

namespace CategoryService
{
    public interface ICategoryRepository
    {

        Task<IEnumerable<Category>> GetAllCategories();
        Task<Category> GetCategoryById(int id);
        Task<Category> CreateCategory(Category category);
        Task<Category> UpdateCategory(int id, Category category);
        Task<bool> DeleteCategory(int id);
    }
}
