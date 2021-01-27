


using Common.APAC.eSKU.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.APAC.eSKU.Common.DAL.EntityConfigurations
{
    public class NotificationConfiguration :  IEntityTypeConfiguration<Notification>
    {

         public void Configure(EntityTypeBuilder<Notification> builder){
               
               builder.ToTable(new Notification().ToString().Substring(new Notification().ToString().LastIndexOf(".")).Trim('.'));
               builder.Property(c => c.NotificationDesc).HasMaxLength(100);
       
         }
    }
  
        
}