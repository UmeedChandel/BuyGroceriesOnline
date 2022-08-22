namespace GroceryAPI.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        public readonly AppDbContext _appDbContext;
        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Category> AllCategories => _appDbContext.Categories;


        Category ICategoryRepository.InsertCategory(Category category)
        {
            var insertCategory = _appDbContext.Categories.Add(category);
            _appDbContext.SaveChanges();
            return insertCategory.Entity;
        }

        Category ICategoryRepository.UpdateCategory(Category category)
        {
            var updateCategory = _appDbContext.Categories.Update(category);
            _appDbContext.SaveChanges();
            return updateCategory.Entity;
        }

        public Category DeleteCategory(int categoryId)
        {
            var deleteCategory = AllCategories.FirstOrDefault(category => category.CategoryId == categoryId);
            var delete = _appDbContext.Categories.Remove(deleteCategory);
            _appDbContext.SaveChanges();
            return delete.Entity;
        }
    }
}
