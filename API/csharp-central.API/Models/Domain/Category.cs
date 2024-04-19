using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace csharp_central.API.Models.Domain
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string UrlHandle { get; set; }

    }
}
