using csharp_central.API.Models.Domain;
using Microsoft.Identity.Client;

namespace csharp_central.API.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);

        Task<IEnumerable<Category>> GetAllAsync();
    }
}
