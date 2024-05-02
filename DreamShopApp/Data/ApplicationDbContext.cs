using DreamShopApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DreamShopApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.                                                                                                                                                                                                                     Entity<ProductOrder>()
                        .HasKey(po => new { po.ProductId, po.OrderId });

            modelBuilder.Entity<ProductOrder>()
                        .HasOne(po => po.Product)
                        .WithMany(p => p.ProductOrders)
                        .HasForeignKey(po => po.ProductId);

            modelBuilder.Entity<ProductOrder>()
                        .HasOne(po => po.Order)
                        .WithMany(o => o.ProductOrders)
                        .HasForeignKey(po => po.OrderId);
        }
    }
}
