
using Common.APAC.eSKU.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.APAC.eSKU.Common.DAL.EntityConfigurations
{
    public class CountryConfiguration :  IEntityTypeConfiguration<Country>
    {

         public void Configure(EntityTypeBuilder<Country> builder){
             
               builder.ToTable(new Country().ToString().Substring(new Country().ToString().LastIndexOf(".")).Trim('.'));
               builder.Property(c => c.CountryName).HasMaxLength(50);
               builder.Property(c => c.CountryCode).HasMaxLength(50);
         }
    }
  
        
}