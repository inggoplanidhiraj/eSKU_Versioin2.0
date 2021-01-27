using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APAC.eSKU.Common.DAL.Migrations
{
    public partial class InitialContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    CountryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CountryCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.CountryID);
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    NotificationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotificationDesc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.NotificationID);
                });

            migrationBuilder.CreateTable(
                name: "ProductGroup",
                columns: table => new
                {
                    ProductGroupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductGroupCode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    ProductGroupName = table.Column<string>(type: "nvarchar(102)", maxLength: 102, nullable: true),
                    ProductGroupAbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Invisible = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGroup", x => x.ProductGroupID);
                });

            migrationBuilder.CreateTable(
                name: "ProductStatus",
                columns: table => new
                {
                    ProductStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductStatusName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductStatus", x => x.ProductStatusID);
                });

            migrationBuilder.CreateTable(
                name: "RequestMode",
                columns: table => new
                {
                    RequestModeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestModeName = table.Column<string>(type: "nvarchar(102)", maxLength: 102, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestMode", x => x.RequestModeID);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserRoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserRoleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.UserRoleID);
                });

            migrationBuilder.CreateTable(
                name: "VendorGroup",
                columns: table => new
                {
                    VendorGroupID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorGroupName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    VendorGroupCode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    SKUPrefix = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    CurrentSequentialNumber = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorGroup", x => x.VendorGroupID);
                });

            migrationBuilder.CreateTable(
                name: "VersionCode",
                columns: table => new
                {
                    VersionCodeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VersionCodeName = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    VersionCodeDesc = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    Suffix = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VersionCode", x => x.VersionCodeID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UsersID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WindowsID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CountryID = table.Column<int>(type: "int", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Department = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SupervisorID = table.Column<int>(type: "int", nullable: false),
                    LastLoginDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    TerminationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UsersID);
                    table.ForeignKey(
                        name: "FK_Users_Country_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Country",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    VendorID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorCode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    VendorGroupID = table.Column<long>(type: "bigint", nullable: false),
                    VendorName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BranchNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    BuyerCode = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CentralizedFlag = table.Column<bool>(type: "bit", nullable: false),
                    Division = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SubDivision = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    ProductManager = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    isRestricted = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    ElectronicFlag = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.VendorID);
                    table.ForeignKey(
                        name: "FK_Vendor_VendorGroup_VendorGroupID",
                        column: x => x.VendorGroupID,
                        principalTable: "VendorGroup",
                        principalColumn: "VendorGroupID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NotificationMap",
                columns: table => new
                {
                    NotificationMapID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotificationID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryID = table.Column<int>(type: "int", nullable: false),
                    UsersID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationMap", x => x.NotificationMapID);
                    table.ForeignKey(
                        name: "FK_NotificationMap_Country_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Country",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotificationMap_Notification_NotificationID",
                        column: x => x.NotificationID,
                        principalTable: "Notification",
                        principalColumn: "NotificationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotificationMap_Users_UsersID",
                        column: x => x.UsersID,
                        principalTable: "Users",
                        principalColumn: "UsersID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserRoleMap",
                columns: table => new
                {
                    UserRoleMapID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    CountryID = table.Column<int>(type: "int", nullable: false),
                    UserRoleID = table.Column<int>(type: "int", nullable: true),
                    UsersID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoleMap", x => x.UserRoleMapID);
                    table.ForeignKey(
                        name: "FK_UserRoleMap_Country_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Country",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoleMap_UserRole_UserRoleID",
                        column: x => x.UserRoleID,
                        principalTable: "UserRole",
                        principalColumn: "UserRoleID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRoleMap_Users_UsersID",
                        column: x => x.UsersID,
                        principalTable: "Users",
                        principalColumn: "UsersID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryID = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProductGroupID = table.Column<int>(type: "int", nullable: false),
                    CPUCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MediaCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    VersionCodeID = table.Column<int>(type: "int", nullable: false),
                    VendorPartNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    VendorID = table.Column<long>(type: "bigint", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Catalog = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: true),
                    Weight = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    High = table.Column<double>(type: "float", nullable: false),
                    Length = table.Column<double>(type: "float", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false),
                    SemiConFlag = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SKU = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RequestStatus = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BasePrice = table.Column<double>(type: "float", nullable: false),
                    MiscCost = table.Column<double>(type: "float", nullable: false),
                    DutyCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TaxCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    VatCode = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    CurrencyCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClassCode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    RetailPrice = table.Column<double>(type: "float", nullable: false),
                    DealerPrice = table.Column<double>(type: "float", nullable: false),
                    ItemTypeCode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    ELectronicFlag = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SerialNbrFlag = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    RestrictedFlag = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    Backorder = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    CommentReq = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CommentCre = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    LanguageCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StateSuffix = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    RequestModeID = table.Column<int>(type: "int", nullable: false),
                    Creator = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MarginScheme = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    ReplacementCost = table.Column<float>(type: "real", nullable: false),
                    AverageCost = table.Column<float>(type: "real", nullable: false),
                    CurrentRetailPrice = table.Column<float>(type: "real", nullable: false),
                    CurrentDealerPrice = table.Column<float>(type: "real", nullable: false),
                    CurrentCol1Price = table.Column<float>(type: "real", nullable: false),
                    CurrentCol2Price = table.Column<float>(type: "real", nullable: false),
                    CurrentCol3Price = table.Column<float>(type: "real", nullable: false),
                    CurrentCol4Price = table.Column<float>(type: "real", nullable: false),
                    CurrentCol5Price = table.Column<float>(type: "real", nullable: false),
                    CurrentCol6Price = table.Column<float>(type: "real", nullable: false),
                    CurrentCol7Price = table.Column<float>(type: "real", nullable: false),
                    Discount = table.Column<float>(type: "real", nullable: false),
                    CountryOfOrigin = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    SKUMarginIND = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SKUFLoorMargin = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GSTCode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    ManufactureName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    HSNCode = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: true),
                    ECCNNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    RestrictionFlag = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    RMA = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    EndUserFlag = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ProductCat = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    BTAXFlag = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    CustCons = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    CRC = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CustCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ProductStatusID = table.Column<int>(type: "int", nullable: false),
                    AdjustedCost = table.Column<float>(type: "real", nullable: false),
                    MiscellaneuousCost = table.Column<float>(type: "real", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DistributedFlag = table.Column<bool>(type: "bit", nullable: false),
                    StatusCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FreightChargeFlag = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SequenceNbr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UsersID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Product_Country_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Country",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_ProductGroup_ProductGroupID",
                        column: x => x.ProductGroupID,
                        principalTable: "ProductGroup",
                        principalColumn: "ProductGroupID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_ProductStatus_ProductStatusID",
                        column: x => x.ProductStatusID,
                        principalTable: "ProductStatus",
                        principalColumn: "ProductStatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_RequestMode_RequestModeID",
                        column: x => x.RequestModeID,
                        principalTable: "RequestMode",
                        principalColumn: "RequestModeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Users_UsersID",
                        column: x => x.UsersID,
                        principalTable: "Users",
                        principalColumn: "UsersID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Vendor_VendorID",
                        column: x => x.VendorID,
                        principalTable: "Vendor",
                        principalColumn: "VendorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_VersionCode_VersionCodeID",
                        column: x => x.VersionCodeID,
                        principalTable: "VersionCode",
                        principalColumn: "VersionCodeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UploadImpulseLog",
                columns: table => new
                {
                    UploadImpulseLogID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<long>(type: "bigint", nullable: false),
                    UploadDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UploadStatus = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    ScreenName = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    UploadType = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    FieldName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ValueBefore = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ValueAfter = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ValueDb = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UploadImpulseLog", x => x.UploadImpulseLogID);
                    table.ForeignKey(
                        name: "FK_UploadImpulseLog_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NotificationMap_CountryID",
                table: "NotificationMap",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationMap_NotificationID",
                table: "NotificationMap",
                column: "NotificationID");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationMap_UsersID",
                table: "NotificationMap",
                column: "UsersID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CountryID",
                table: "Product",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductGroupID",
                table: "Product",
                column: "ProductGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductStatusID",
                table: "Product",
                column: "ProductStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_RequestModeID",
                table: "Product",
                column: "RequestModeID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_UsersID",
                table: "Product",
                column: "UsersID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_VendorID",
                table: "Product",
                column: "VendorID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_VersionCodeID",
                table: "Product",
                column: "VersionCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_UploadImpulseLog_ProductID",
                table: "UploadImpulseLog",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleMap_CountryID",
                table: "UserRoleMap",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleMap_UserRoleID",
                table: "UserRoleMap",
                column: "UserRoleID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleMap_UsersID",
                table: "UserRoleMap",
                column: "UsersID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CountryID",
                table: "Users",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_Vendor_VendorGroupID",
                table: "Vendor",
                column: "VendorGroupID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotificationMap");

            migrationBuilder.DropTable(
                name: "UploadImpulseLog");

            migrationBuilder.DropTable(
                name: "UserRoleMap");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "ProductGroup");

            migrationBuilder.DropTable(
                name: "ProductStatus");

            migrationBuilder.DropTable(
                name: "RequestMode");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Vendor");

            migrationBuilder.DropTable(
                name: "VersionCode");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "VendorGroup");
        }
    }
}
