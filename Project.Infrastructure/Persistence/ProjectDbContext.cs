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
        public DbSet<StockRecord> StockRecords { get; set; }
        public DbSet<SalesDetail> SalesDetails { get; set; }
        public DbSet<SalesHistory> SalesHistory { get; set; }
        public DbSet<Stock> Stocks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //this will enfore unique product code
            modelBuilder.Entity<Product>()
                .HasIndex(b => b.ProductCode)
                .IsUnique();

            //this will enfore unique product name
            modelBuilder.Entity<Product>()
                .HasIndex(b => b.ProductName)
                .IsUnique();

            //this will enforce unique category name
            modelBuilder.Entity<Category>()
                .HasIndex(b => b.CategoryName)
                .IsUnique();

            //each StockId will only have one ProductId
            modelBuilder.Entity<Stock>()
                .HasIndex(b => b.ProductId)
                .IsUnique();

            modelBuilder.Entity<Product>()
                .Property(p => p.ProductPrice)
                .HasColumnType("decimal(18,2)");



            //CANNOT DELETE a Category if there are still Products linked to it
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            //CANNOT DELETE a Product if there are still Stock linked to it
            //modelBuilder.Entity<Stock>()
            //    .HasOne(s => s.Product)
            //    .WithOne(p => p.Stock)
            //    .HasForeignKey<Stock>(s => s.ProductId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //CANNOT DELETE a Product if there are still StockRecords linked to it
            //modelBuilder.Entity<StockRecord>()
            //    .HasOne(s => s.Product)
            //    .WithMany(p => p.StockRecords)
            //    .HasForeignKey(s => s.ProductId)
            //    .OnDelete(DeleteBehavior.Cascade);

            //CANNOT DELETE a SalesHistory if there are still SalesDetails linked to it
            modelBuilder.Entity<SalesDetail>()
                .HasOne(sd => sd.SalesHistory)
                .WithMany(sh => sh.SalesDetails)
                .HasForeignKey(sd => sd.SalesHistoryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<SalesHistory>()
                .Property(e => e.SaleDate)
                .HasConversion(
                v => v.ToDateTime(TimeOnly.MinValue),
                v => DateOnly.FromDateTime(v));

            modelBuilder.Entity<StockRecord>()
                .Property(e => e.StockInDate)
                .HasConversion(
                v => v.ToDateTime(TimeOnly.MinValue),
                v => DateOnly.FromDateTime(v));

            base.OnModelCreating(modelBuilder);
        }
    }
}
    