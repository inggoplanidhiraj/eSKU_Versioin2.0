

using Common.APAC.eSKU.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.APAC.eSKU.Common.DAL.EntityConfigurations
{
    public class NotificationMapConfiguration : IEntityTypeConfiguration<NotificationMap>
    {
     public void Configure(EntityTypeBuilder<NotificationMap> builder)
     {
               
     builder.ToTable(new NotificationMap().ToString().Substring(new NotificationMap().ToString().LastIndexOf(".")).Trim('.'));
              
       
     }
    }
}