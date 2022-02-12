using InfoNinjasApi.Features.NinjaFeatures;
using Microsoft.EntityFrameworkCore;

namespace InfoNinjasApi.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<NinjaItem> NinjaItems { get; set; } = null!;

    }
}
