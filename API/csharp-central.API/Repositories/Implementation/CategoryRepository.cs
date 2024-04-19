using csharp_central.API.Data;
using csharp_central.API.Repositories.Interface;
using csharp_central.API.Models.Domain;

namespace csharp_central.API.Repositories.Implementation
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly ApplicationDbContext dbContext;

        public CategoryRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Category> CreateAsync(Category category)
        {
            await dbContext.Categories.AddAsync(category);
            await dbContext.SaveChangesAsync();

            return category;
        }
    }
}
