
using Common.APAC.eSKU.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.APAC.eSKU.Common.DAL.EntityConfigurations
{
    public class UserRoleMapConfiguration : IEntityTypeConfiguration<UserRoleMap>
    {
       
        public void Configure(EntityTypeBuilder<UserRoleMap> builder)
        {
            builder.ToTable(new UserRoleMap().ToString().Substring(new UserRoleMap().ToString().LastIndexOf(".")).Trim('.'));
          
        }
    }
}