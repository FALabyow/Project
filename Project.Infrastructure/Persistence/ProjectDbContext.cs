using Microsoft.EntityFrameworkCore;
using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.Persistence
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories  { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasIndex(b => b.ProductCode)
                .IsUnique();

            modelBuilder.Entity<Product>()
                .HasIndex(b => b.ProductName)
                .IsUnique();

            modelBuilder.Entity<Category>()
                .HasIndex(b => b.CategoryName)
                .IsUnique();

            modelBuilder.Entity<Product>()
                .Property(p => p.ProductPrice)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}
    