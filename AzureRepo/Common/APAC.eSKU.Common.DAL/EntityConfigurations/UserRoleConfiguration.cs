
using Common.APAC.eSKU.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.APAC.eSKU.Common.DAL.EntityConfigurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
       
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
           builder.ToTable(new UserRole().ToString().Substring(new UserRole().ToString().LastIndexOf(".")).Trim('.'));
           builder.Property(c => c.UserRoleName).HasMaxLength(100);
        }
        
    }
}