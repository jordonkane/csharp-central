using csharp_central.API.Models.Domain;

namespace csharp_central.API.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);
    }
}
