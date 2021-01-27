
using Common.APAC.eSKU.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.APAC.eSKU.Common.DAL.EntityConfigurations
{
    public class VendorConfiguration : IEntityTypeConfiguration<Vendor>
    {
       
        public void Configure(EntityTypeBuilder<Vendor> builder)
        {
            builder.ToTable(new Vendor().ToString().Substring(new Vendor().ToString().LastIndexOf(".")).Trim('.'));
            builder.Property(c => c.VendorCode).HasMaxLength(8);
            builder.Property(c => c.VendorName).HasMaxLength(100);
            builder.Property(c => c.BuyerCode).HasMaxLength(40);
            builder.Property(c => c.BranchNumber).HasMaxLength(20);
            builder.Property(c => c.Division).HasMaxLength(10);
            builder.Property(c => c.SubDivision).HasMaxLength(10);
            builder.Property(c => c.ModifiedBy).HasMaxLength(60);
            builder.Property(c => c.CreatedBy).HasMaxLength(60);
            builder.Property(c => c.ProductManager).HasMaxLength(100);
            builder.Property(c => c.isRestricted).HasMaxLength(2);
            builder.Property(c => c.ElectronicFlag).HasMaxLength(2);
          


        }
    }
}