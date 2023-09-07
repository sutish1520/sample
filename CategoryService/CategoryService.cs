using CategoryService.Model;

namespace CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await _repository.GetAllCategories();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await _repository.GetCategoryById(id);
        }

        public async Task<Category> CreateCategory(Category category)
        {
            category.CreationDate = DateTime.Now;
            return await _repository.CreateCategory(category);
        }

        public async Task<Category> UpdateCategory(int id, Category category)
        {
            return await _repository.UpdateCategory(id, category);
        }

        public async Task<bool> DeleteCategory(int id)
        {
            return await _repository.DeleteCategory(id);
        }
    }
}