
using Common.APAC.eSKU.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.APAC.eSKU.Common.DAL.EntityConfigurations
{
    public class VersionCodeConfiguration : IEntityTypeConfiguration<VersionCode>
    {
       
        public void Configure(EntityTypeBuilder<VersionCode> builder)
        {
           builder.ToTable(new VersionCode().ToString().Substring(new VersionCode().ToString().LastIndexOf(".")).Trim('.'));
             builder.Property(c => c.VersionCodeDesc).HasMaxLength(6);
             builder.Property(c => c.VersionCodeName).HasMaxLength(2);
             builder.Property(c => c.Suffix).HasMaxLength(1);
             builder.Property(c => c.Description).HasMaxLength(80);
       
        }


    }
}