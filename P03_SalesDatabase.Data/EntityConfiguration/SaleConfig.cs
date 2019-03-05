using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P03_SalesDatabase.Data.Models;
using P03_SalesDatabase.Data;

namespace P03_SalesDatabase.Data.EntityConfiguration
{
    public class SaleConfig : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.HasKey(x => x.SaleId);

            builder.HasOne(e => e.Product)
                .WithMany(s => s.Sales)
                .HasForeignKey(e => e.ProductId);

            builder.HasOne(e => e.Store)
                .WithMany(s => s.Sales)
                .HasForeignKey(e => e.StoreId);

            builder.HasOne(e => e.Customer)
                .WithMany(s => s.Sales)
                .HasForeignKey(e => e.CustomerId);

            builder.Property(x => x.Date)
                .IsRequired()
                .HasDefaultValueSql("GETDATE()");

        }
    }
}