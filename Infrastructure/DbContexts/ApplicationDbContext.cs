using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        private readonly StreamWriter _logStream = 
            new("EFCoreDebug.log", append: true);
        public DbSet<Product> Products { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Epaper> Epapers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options
            ) : base(options) 
        { 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.LogTo(_logStream.WriteLine);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Account>().ToTable("Account");
            modelBuilder.Entity<Epaper>().ToTable("Epaper");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Promotion>().ToTable("Promotion");
            modelBuilder.Entity<ShoppingCart>().ToTable("ShoppingCart");
        }

        public override void Dispose()
        {
            base.Dispose();
            _logStream.Dispose();
        }

        public override async ValueTask DisposeAsync()
        {
            await base.DisposeAsync();
            await _logStream.DisposeAsync();
        }
    }
}
