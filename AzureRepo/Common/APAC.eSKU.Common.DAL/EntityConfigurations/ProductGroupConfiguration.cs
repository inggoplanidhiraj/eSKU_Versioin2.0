

using Common.APAC.eSKU.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.APAC.eSKU.Common.DAL.EntityConfigurations
{
    public class ProductGroupConfiguration : IEntityTypeConfiguration<ProductGroup>
    {
     public void Configure(EntityTypeBuilder<ProductGroup> builder)
     {
    

          builder.ToTable(new ProductGroup().ToString().Substring(new ProductGroup().ToString().LastIndexOf(".")).Trim('.'));
          builder.Property(c => c.ProductGroupCode).HasMaxLength(8);
          builder.Property(c => c.ProductGroupName).HasMaxLength(102);
          builder.Property(c => c.ProductGroupAbreviation).HasMaxLength(20);
          builder.Property(c => c.Invisible).HasMaxLength(2);

        }
        
    }
}