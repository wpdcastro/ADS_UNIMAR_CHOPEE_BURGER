using ChopeeBurgerAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChopeeBurgerAPI.Data.Context
{
    public class BaseContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }

        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasKey(client => client.Id);

            modelBuilder.Entity<Product>()
                .HasKey(prod => prod.Id);

            modelBuilder.Entity<Sale>()
                .HasKey(sale => sale.Id);

            modelBuilder.Entity<Sale>()
                .HasOne(sale => sale.Product)
                .WithMany(prod => prod.Sales)
                .HasForeignKey(sale => sale.ProductId);

            modelBuilder.Entity<Sale>()
                .HasOne(sale => sale.Client)
                .WithMany(client => client.Sales)
                .HasForeignKey(sale => sale.ClientId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
