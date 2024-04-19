using csharp_central.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace csharp_central.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPost { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
