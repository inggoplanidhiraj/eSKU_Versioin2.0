
using Common.APAC.eSKU.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.APAC.eSKU.Common.DAL.EntityConfigurations
{
    public class UploadImpulseLogConfiguration : IEntityTypeConfiguration<UploadImpulseLog>
    {
       
        public void Configure(EntityTypeBuilder<UploadImpulseLog> builder)
        {
           builder.ToTable(new UploadImpulseLog().ToString().Substring(new UploadImpulseLog().ToString().LastIndexOf(".")).Trim('.'));
            builder.Property(c => c.ScreenName).HasMaxLength(16);
            builder.Property(c => c.UploadStatus).HasMaxLength(2);
            builder.Property(c => c.UploadType).HasMaxLength(14);
            builder.Property(c => c.FieldName).HasMaxLength(40);
            builder.Property(c => c.ValueAfter).HasMaxLength(100);
            builder.Property(c => c.ValueBefore).HasMaxLength(100);
            builder.Property(c => c.ValueDb).HasMaxLength(100);
            
       
        }
    }
}