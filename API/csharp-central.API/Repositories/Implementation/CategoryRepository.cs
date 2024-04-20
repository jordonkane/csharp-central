using csharp_central.API.Data;
using csharp_central.API.Repositories.Interface;
using csharp_central.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

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

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await dbContext.Categories.ToListAsync();
        }
    }
}
