using Microsoft.EntityFrameworkCore;

namespace AngularDemo.Models {
    public class ApplicationDBContext : DbContext {
        public ApplicationDBContext (DbContextOptions<ApplicationDBContext> options) : base (options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}