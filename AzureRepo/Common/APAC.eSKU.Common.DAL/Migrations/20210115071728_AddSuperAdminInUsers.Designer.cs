﻿// <auto-generated />
using System;
using Common.APAC.eSKU.Common.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APAC.eSKU.Common.DAL.Migrations
{
    [DbContext(typeof(eSKUContext))]
    [Migration("20210115071728_AddSuperAdminInUsers")]
    partial class AddSuperAdminInUsers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Common.APAC.eSKU.Common.Entities.Country", b =>
                {
                    b.Property<int>("CountryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CountryCode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CountryName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CountryID");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("Common.APAC.eSKU.Common.Entities.Notification", b =>
                {
                    b.Property<int>("NotificationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("NotificationDesc")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("NotificationID");

                    b.ToTable("Notification");
                });

            modelBuilder.Entity("Common.APAC.eSKU.Common.Entities.NotificationMap", b =>
                {
                    b.Property<int>("NotificationMapID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CountryID")
                        .HasColumnType("int");

                    b.Property<int>("NotificationID")
                        .HasColumnType("int");

                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsersID")
                        .HasColumnType("int");

                    b.HasKey("NotificationMapID");

                    b.HasIndex("CountryID");

                    b.HasIndex("NotificationID");

                    b.HasIndex("UsersID");

                    b.ToTable("NotificationMap");
                });

            modelBuilder.Entity("Common.APAC.eSKU.Common.Entities.Product", b =>
                {
                    b.Property<long>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<float>("AdjustedCost")
                        .HasColumnType("real");

                    b.Property<float>("AverageCost")
                        .HasColumnType("real");

                    b.Property<string>("BTAXFlag")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("Backorder")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<double>("BasePrice")
                        .HasColumnType("float");

                    b.Property<string>("CPUCode")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CRC")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Catalog")
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.Property<string>("Category")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ClassCode")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("CommentCre")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("CommentReq")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("CountryID")
                        .HasColumnType("int");

                    b.Property<string>("CountryOfOrigin")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Creator")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CurrencyCode")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<float>("CurrentCol1Price")
                        .HasColumnType("real");

                    b.Property<float>("CurrentCol2Price")
                        .HasColumnType("real");

                    b.Property<float>("CurrentCol3Price")
                        .HasColumnType("real");

                    b.Property<float>("CurrentCol4Price")
                        .HasColumnType("real");

                    b.Property<float>("CurrentCol5Price")
                        .HasColumnType("real");

                    b.Property<float>("CurrentCol6Price")
                        .HasColumnType("real");

                    b.Property<float>("CurrentCol7Price")
                        .HasColumnType("real");

                    b.Property<float>("CurrentDealerPrice")
                        .HasColumnType("real");

                    b.Property<float>("CurrentRetailPrice")
                        .HasColumnType("real");

                    b.Property<string>("CustCode")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("CustCons")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<double>("DealerPrice")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description2")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<bool>("DistributedFlag")
                        .HasColumnType("bit");

                    b.Property<string>("DutyCode")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ECCNNo")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ELectronicFlag")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("EndUserFlag")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("FreightChargeFlag")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("GSTCode")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("HSNCode")
                        .HasMaxLength(90)
                        .HasColumnType("nvarchar(90)");

                    b.Property<double>("High")
                        .HasColumnType("float");

                    b.Property<string>("ItemTypeCode")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("LanguageCode")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("LastModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Length")
                        .HasColumnType("float");

                    b.Property<string>("ManufactureName")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("MarginScheme")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("MediaCode")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("MiscCost")
                        .HasColumnType("float");

                    b.Property<float>("MiscellaneuousCost")
                        .HasColumnType("real");

                    b.Property<string>("ProductCat")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<int>("ProductGroupID")
                        .HasColumnType("int");

                    b.Property<int>("ProductStatusID")
                        .HasColumnType("int");

                    b.Property<string>("RMA")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<float>("ReplacementCost")
                        .HasColumnType("real");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RequestModeID")
                        .HasColumnType("int");

                    b.Property<string>("RequestStatus")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("RestrictedFlag")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("RestrictionFlag")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<double>("RetailPrice")
                        .HasColumnType("float");

                    b.Property<string>("SKU")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SKUFLoorMargin")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("SKUMarginIND")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("SemiConFlag")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SequenceNbr")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SerialNbrFlag")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("StateSuffix")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("StatusCode")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TaxCode")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsersID")
                        .HasColumnType("int");

                    b.Property<string>("VatCode")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<long>("VendorID")
                        .HasColumnType("bigint");

                    b.Property<string>("VendorPartNumber")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("VersionCodeID")
                        .HasColumnType("int");

                    b.Property<string>("Weight")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.HasKey("ProductID");

                    b.HasIndex("CountryID");

                    b.HasIndex("ProductGroupID");

                    b.HasIndex("ProductStatusID");

                    b.HasIndex("RequestModeID");

                    b.HasIndex("UsersID");

                    b.HasIndex("VendorID");

                    b.HasIndex("VersionCodeID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Common.APAC.eSKU.Common.Entities.ProductGroup", b =>
                {
                    b.Property<int>("ProductGroupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Invisible")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("ProductGroupAbreviation")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ProductGroupCode")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("ProductGroupName")
                        .HasMaxLength(102)
                        .HasColumnType("nvarchar(102)");

                    b.HasKey("ProductGroupID");

                    b.ToTable("ProductGroup");
                });

            modelBuilder.Entity("Common.APAC.eSKU.Common.Entities.ProductStatus", b =>
                {
                    b.Property<int>("ProductStatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ProductStatusName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ProductStatusID");

                    b.ToTable("ProductStatus");
                });

            modelBuilder.Entity("Common.APAC.eSKU.Common.Entities.RequestMode", b =>
                {
                    b.Property<int>("RequestModeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("RequestModeName")
                        .HasMaxLength(102)
                        .HasColumnType("nvarchar(102)");

                    b.HasKey("RequestModeID");

                    b.ToTable("RequestMode");
                });

            modelBuilder.Entity("Common.APAC.eSKU.Common.Entities.UploadImpulseLog", b =>
                {
                    b.Property<long>("UploadImpulseLogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("FieldName")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<long>("ProductID")
                        .HasColumnType("bigint");

                    b.Property<string>("ScreenName")
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<DateTime>("UploadDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UploadStatus")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("UploadType")
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("ValueAfter")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ValueBefore")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ValueDb")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("UploadImpulseLogID");

                    b.HasIndex("ProductID");

                    b.ToTable("UploadImpulseLog");
                });

            modelBuilder.Entity("Common.APAC.eSKU.Common.Entities.UserRole", b =>
                {
                    b.Property<int>("UserRoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("UserRoleName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("UserRoleID");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("Common.APAC.eSKU.Common.Entities.UserRoleMap", b =>
                {
                    b.Property<int>("UserRoleMapID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CountryID")
                        .HasColumnType("int");

                    b.Property<int>("UserRoleID")
                        .HasColumnType("int");

                    b.Property<int>("UsersID")
                        .HasColumnType("int");

                    b.HasKey("UserRoleMapID");

                    b.HasIndex("CountryID");

                    b.HasIndex("UserRoleID");

                    b.HasIndex("UsersID");

                    b.ToTable("UserRoleMap");
                });

            modelBuilder.Entity("Common.APAC.eSKU.Common.Entities.Users", b =>
                {
                    b.Property<int>("UsersID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Comment")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ContactNumber")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("CountryID")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Department")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("LastLoginDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("SuperAdmin")
                        .HasColumnType("bit");

                    b.Property<int>("SupervisorID")
                        .HasColumnType("int");

                    b.Property<DateTime>("TerminationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("WindowsID")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("UsersID");

                    b.HasIndex("CountryID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Common.APAC.eSKU.Common.Entities.Vendor", b =>
                {
                    b.Property<long>("VendorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("BranchNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("BuyerCode")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<bool>("CentralizedFlag")
                        .HasColumnType("bit");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Division")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ElectronicFlag")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductManager")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SubDivision")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("VendorCode")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<long>("VendorGroupID")
                        .HasColumnType("bigint");

                    b.Property<string>("VendorName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("isRestricted")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.HasKey("VendorID");

                    b.HasIndex("VendorGroupID");

                    b.ToTable("Vendor");
                });

            modelBuilder.Entity("Common.APAC.eSKU.Common.Entities.VendorGroup", b =>
                {
                    b.Property<long>("VendorGroupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("CurrentSequentialNumber")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("SKUPrefix")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("VendorGroupCode")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("VendorGroupName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("VendorGroupID");

                    b.ToTable("VendorGroup");
                });

            modelBuilder.Entity("Common.APAC.eSKU.Common.Entities.VersionCode", b =>
                {
                    b.Property<int>("VersionCodeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Suffix")
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("VersionCodeDesc")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("VersionCodeName")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.HasKey("VersionCodeID");

                    b.ToTable("VersionCode");
                });

            modelBuilder.Entity("Common.APAC.eSKU.Common.Entities.NotificationMap", b =>
                {
                    b.HasOne("Common.APAC.eSKU.Common.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Common.APAC.eSKU.Common.Entities.Notification", "Notification")
                        .WithMany()
                        .HasForeignKey("NotificationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Common.APAC.eSKU.Common.Entities.Users", "User")
                        .WithMany()
                        .HasForeignKey("UsersID");

                    b.Navigation("Country");

                    b.Navigation("Notification");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Common.APAC.eSKU.Common.Entities.Product", b =>
                {
                    b.HasOne("Common.APAC.eSKU.Common.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Common.APAC.eSKU.Common.Entities.ProductGroup", "ProductGroup")
                        .WithMany()
                        .HasForeignKey("ProductGroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Common.APAC.eSKU.Common.Entities.ProductStatus", "ProductStatus")
                        .WithMany()
                        .HasForeignKey("ProductStatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Common.APAC.eSKU.Common.Entities.RequestMode", "RequestMode")
                        .WithMany()
                        .HasForeignKey("RequestModeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Common.APAC.eSKU.Common.Entities.Users", "Users")
                        .WithMany()
                        .HasForeignKey("UsersID");

                    b.HasOne("Common.APAC.eSKU.Common.Entities.Vendor", "Vendor")
                        .WithMany()
                        .HasForeignKey("VendorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Common.APAC.eSKU.Common.Entities.VersionCode", "VersionCode")
                        .WithMany()
                        .HasForeignKey("VersionCodeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("ProductGroup");

                    b.Navigation("ProductStatus");

                    b.Navigation("RequestMode");

                    b.Navigation("Users");

                    b.Navigation("Vendor");

                    b.Navigation("VersionCode");
                });

            modelBuilder.Entity("Common.APAC.eSKU.Common.Entities.UploadImpulseLog", b =>
                {
                    b.HasOne("Common.APAC.eSKU.Common.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Common.APAC.eSKU.Common.Entities.UserRoleMap", b =>
                {
                    b.HasOne("Common.APAC.eSKU.Common.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Common.APAC.eSKU.Common.Entities.UserRole", "UserRole")
                        .WithMany()
                        .HasForeignKey("UserRoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Common.APAC.eSKU.Common.Entities.Users", "users")
                        .WithMany()
                        .HasForeignKey("UsersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("UserRole");

                    b.Navigation("users");
                });

            modelBuilder.Entity("Common.APAC.eSKU.Common.Entities.Users", b =>
                {
                    b.HasOne("Common.APAC.eSKU.Common.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Common.APAC.eSKU.Common.Entities.Vendor", b =>
                {
                    b.HasOne("Common.APAC.eSKU.Common.Entities.VendorGroup", "VendorGroup")
                        .WithMany()
                        .HasForeignKey("VendorGroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VendorGroup");
                });
#pragma warning restore 612, 618
        }
    }
}
