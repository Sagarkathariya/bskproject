using Microsoft.EntityFrameworkCore;

namespace bskproject.Controllers
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; } = null!;
    }
}
