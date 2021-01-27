
using Common.APAC.eSKU.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.APAC.eSKU.Common.DAL.EntityConfigurations
{
    public class UsersConfiguration : IEntityTypeConfiguration<Users>
    {
       
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.ToTable(new Users().ToString().Substring(new Users().ToString().LastIndexOf(".")).Trim('.'));
            builder.Property(c => c.WindowsID).HasMaxLength(20);
            builder.Property(c => c.ContactNumber).HasMaxLength(100);
            builder.Property(c => c.Department).HasMaxLength(100);
            builder.Property(c => c.Email).HasMaxLength(100);
            builder.Property(c => c.UserName).HasMaxLength(100);
            builder.Property(c => c.CreatedBy).HasMaxLength(100);
            builder.Property(c => c.Comment).HasMaxLength(100);
            



        }
    }
}