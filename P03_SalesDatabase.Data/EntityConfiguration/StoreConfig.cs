using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P03_SalesDatabase.Data.Models;

namespace P03_SalesDatabase.Data.EntityConfiguration
{
    public class StoreConfig : IEntityTypeConfiguration<Models.Store>
    {
        public void Configure(EntityTypeBuilder<Models.Store> builder)
        {
            builder.HasKey(x => x.StoreId);

            builder.Property(x => x.Name)
                .HasMaxLength(80)
                .IsUnicode();
        }
    }
}