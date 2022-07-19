using AbbyWeb.Model;
using Microsoft.EntityFrameworkCore;

namespace AbbyWeb.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // Add all tables here
        public DbSet<Category> Category { get; set; }
        public DbSet<MenuItem> MenuItem { get; set; }
    }
}
