using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.EntitiesConfiguration;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(t => t.Name)
            .HasMaxLength(50)
            .IsRequired();
        builder.Property(t => t.Description)
            .HasMaxLength(150);
        builder.Property(t => t.PurchasePrice)
            .IsRequired()
            .HasPrecision(10, 2);
        builder.Property(t => t.SellingPrice)
            .IsRequired()
            .HasPrecision(10, 2);
        builder.Property(t => t.StokeQuantity)
            .IsRequired();
        builder.Property(t => t.ExpiryDate);

        builder.HasOne(s => s.Supplier)
            .WithMany(p => p.Products)
            .HasForeignKey(p => p.SupplierId);
    }
}
