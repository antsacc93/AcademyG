using AcademyG.Week8.Amazon.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace AcademyG.Week8.Amazon.EF
{
    public class AmazonContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public AmazonContext(DbContextOptions<AmazonContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var prodEntity = builder.Entity<Product>();

            prodEntity.HasKey(e => e.Id);

            prodEntity.Property(e => e.Code)
                          .IsRequired()
                          .HasMaxLength(5);

            prodEntity.Property(e => e.Description)
              .IsRequired()
              .HasMaxLength(200);

            prodEntity.Property(e => e.Type)
                .HasConversion(
                    v => v.ToString(),
                    v => (ProductType)Enum.Parse(typeof(ProductType), v)); 

            prodEntity.Property(e => e.Price);
            prodEntity.Property(e => e.PurchasePrice);

            prodEntity.HasData(new Product
            {
                Id = 1,
                Code = "12345",
                Price = 23.2M,
                Type = ProductType.Electronic,
                PurchasePrice = 1.2M,
                Description = "TV 55 inch Samsung"
            });
        }
    }
}
