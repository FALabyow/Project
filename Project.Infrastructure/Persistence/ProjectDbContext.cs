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
                .HasIndex(b => b.ProductCode) // 🔹 Creates an index
                .IsUnique();            // 🔹 Ensures uniqueness

            modelBuilder.Entity<Category>()
                .HasIndex(b => b.CategoryCode) // 🔹 Creates an index
                .IsUnique();            // 🔹 Ensures uniqueness

            base.OnModelCreating(modelBuilder);
        }
    }
}
    