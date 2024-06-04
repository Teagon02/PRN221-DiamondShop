using Diamond.DataAccess.Configuration;
using Diamond.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Diamond.DataAccess.Data
{
    public class DiamondDbContext : DbContext
    {
        public DiamondDbContext(DbContextOptions<DiamondDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CategoryConfiguaration());
            builder.ApplyConfiguration(new ProductConfiguaration());        
        }
    }
}
