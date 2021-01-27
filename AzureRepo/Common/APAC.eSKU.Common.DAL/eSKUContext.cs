using Common.APAC.eSKU.Common.UtilityHelper.Constants;
using Common.APAC.eSKU.Common.Entities;
using Common.APAC.eSKU.Common.DAL.EntityConfigurations;

using Microsoft.EntityFrameworkCore;


namespace Common.APAC.eSKU.Common.DAL
{
    public class eSKUContext : DbContext
  {
         
 public eSKUContext()
        {
        }

        public eSKUContext(DbContextOptions<eSKUContext> options)
            : base(options)
        {
        }
            public virtual DbSet<Country> Countries { get; set; }
            public virtual DbSet<Users> Users { get; set; }
            public virtual DbSet<UserRole> UserRoles { get; set; }
 
            public virtual DbSet<UserRoleMap> UserRoleMap { get; set; }
            public virtual DbSet<VendorGroup> VendorGroups { get; set; }
            public virtual DbSet<Vendor> Vendors { get; set; }
            public virtual DbSet<VersionCode> VersionCodes { get; set; }
            public virtual DbSet<RequestMode> RequestModes { get; set; }
            public virtual DbSet<ProductGroup> ProductGroups { get; set; }
            public virtual DbSet<Product> Products { get; set; }
            public virtual DbSet<ProductStatus> ProductStatus { get; set; }
            public virtual DbSet<UploadImpulseLog> UploadImpulseLogs { get; set; }
            public virtual DbSet<Notification> Notifications { get; set; }
            public virtual DbSet<NotificationMap> NotificationMap { get; set; }

      	
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=SGDCWSQL4001;initial Catalog=eSKUDB;User Id=imipl;Password=imipl;Min Pool Size=5;Max Pool Size=600;Connect Timeout=0;MultipleActiveResultSets=true;");
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
             builder.ApplyConfiguration(new CountryConfiguration());
            builder.ApplyConfiguration(new UsersConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());
            builder.ApplyConfiguration(new UserRoleMapConfiguration());
            builder.ApplyConfiguration(new VendorGroupConfiguration());
            builder.ApplyConfiguration(new VendorConfiguration());
            builder.ApplyConfiguration(new VersionCodeConfiguration());
            builder.ApplyConfiguration(new RequestModeConfiguration());
            builder.ApplyConfiguration(new ProductGroupConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new ProductStatusConfiguration());
            builder.ApplyConfiguration(new UploadImpulseLogConfiguration());
            builder.ApplyConfiguration(new NotificationConfiguration());
            builder.ApplyConfiguration(new NotificationMapConfiguration());
            builder.ApplyConfiguration(new VersionCodeConfiguration());



        }

    }
}