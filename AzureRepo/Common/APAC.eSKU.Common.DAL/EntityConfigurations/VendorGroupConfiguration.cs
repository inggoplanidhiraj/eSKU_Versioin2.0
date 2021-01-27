
using Common.APAC.eSKU.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.APAC.eSKU.Common.DAL.EntityConfigurations
{
    public class VendorGroupConfiguration : IEntityTypeConfiguration<VendorGroup>
    {
       
        public void Configure(EntityTypeBuilder<VendorGroup> builder)
        {
            builder.ToTable(new VendorGroup().ToString().Substring(new VendorGroup().ToString().LastIndexOf(".")).Trim('.'));
            builder.Property(c => c.VendorGroupCode).HasMaxLength(8);
            builder.Property(c => c.VendorGroupName).HasMaxLength(100);
            builder.Property(c => c.SKUPrefix).HasMaxLength(6);
            builder.Property(c => c.CurrentSequentialNumber).HasMaxLength(8);
        }
    }
}