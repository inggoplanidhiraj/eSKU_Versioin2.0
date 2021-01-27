

using Common.APAC.eSKU.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.APAC.eSKU.Common.DAL.EntityConfigurations
{
    public class ProductStatusConfiguration : IEntityTypeConfiguration<ProductStatus>
    {
     public void Configure(EntityTypeBuilder<ProductStatus> builder)
     {
    

          builder.ToTable(new ProductStatus().ToString().Substring(new ProductStatus().ToString().LastIndexOf(".")).Trim('.'));
          builder.Property(c => c.ProductStatusName).HasMaxLength(100);
       

       

    }
}
}