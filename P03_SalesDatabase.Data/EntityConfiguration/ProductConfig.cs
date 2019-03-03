using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P03_SalesDatabase.Data.Models;

namespace P03_SalesDatabase.Data.EntityConfiguration
{
    public class ProductConfig : IEntityTypeConfiguration<Models.Product>
    {
        public void Configure(EntityTypeBuilder<Models.Product> builder)
        {
            builder.HasKey(x => x.ProductId);

            builder.Property(x => x.Name)
                .HasMaxLength(50)
                .IsUnicode();


            builder.Property(x => x.Description)
                .HasMaxLength(250)
                .IsUnicode()
                .HasDefaultValue("No description");
        }
    }
}