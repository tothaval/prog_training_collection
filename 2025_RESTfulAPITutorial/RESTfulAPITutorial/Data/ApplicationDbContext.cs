using Microsoft.EntityFrameworkCore;
using RESTfulAPITutorial.Model;

namespace RESTfulAPITutorial.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ApplicationDbContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {
            
        }
    }
}
