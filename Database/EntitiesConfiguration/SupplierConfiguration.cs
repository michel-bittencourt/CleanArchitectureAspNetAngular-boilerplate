using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.EntitiesConfiguration;

public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
{
    public void Configure(EntityTypeBuilder<Supplier> builder)
    {
        builder.HasKey(s => s.Id);
        builder.Property(s => s.Name)
            .IsRequired()
            .HasMaxLength(50);
        builder.Property(s => s.TaxID)
            .IsRequired()
            .HasMaxLength(50);
        builder.Property(s => s.Address)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(s => s.Contact)
            .IsRequired()
            .HasMaxLength(15);
    }
}
