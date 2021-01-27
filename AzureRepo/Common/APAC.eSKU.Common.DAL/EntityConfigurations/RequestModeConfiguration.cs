

using Common.APAC.eSKU.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.APAC.eSKU.Common.DAL.EntityConfigurations
{
    public class RequestModeConfiguration : IEntityTypeConfiguration<RequestMode>
    {
     public void Configure(EntityTypeBuilder<RequestMode> builder)
     {
    

           builder.ToTable(new RequestMode().ToString().Substring(new RequestMode().ToString().LastIndexOf(".")).Trim('.'));
           builder.Property(c => c.RequestModeName).HasMaxLength(102);

        }

    }
}