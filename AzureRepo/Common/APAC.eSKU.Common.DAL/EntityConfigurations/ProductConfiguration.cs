

using Common.APAC.eSKU.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.APAC.eSKU.Common.DAL.EntityConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
     public void Configure(EntityTypeBuilder<Product> builder)
     {
    
          builder.ToTable(new Product().ToString().Substring(new NotificationMap().ToString().LastIndexOf(".")).Trim('.'));
          builder.Property(c => c.Description).HasMaxLength(100);
          builder.Property(c => c.Description2).HasMaxLength(100);
          builder.Property(c => c.CPUCode).HasMaxLength(100);
          builder.Property(c => c.MediaCode).HasMaxLength(100);
          builder.Property(c => c.VendorPartNumber).HasMaxLength(100);
          builder.Property(c => c.Category).HasMaxLength(100);
          builder.Property(c => c.Catalog).HasMaxLength(24);
          builder.Property(c => c.Weight).HasMaxLength(10);
          builder.Property(c => c.SemiConFlag).HasMaxLength(100);
          builder.Property(c => c.SKU).HasMaxLength(100);
          builder.Property(c => c.RequestStatus).HasMaxLength(100);
          builder.Property(c => c.DutyCode).HasMaxLength(100);
          builder.Property(c => c.TaxCode).HasMaxLength(100);
          builder.Property(c => c.VatCode).HasMaxLength(4);
          builder.Property(c => c.CurrencyCode).HasMaxLength(100);
          builder.Property(c => c.ClassCode).HasMaxLength(2);
          builder.Property(c => c.ItemTypeCode).HasMaxLength(2);
          builder.Property(c => c.ELectronicFlag).HasMaxLength(2);
          builder.Property(c => c.SerialNbrFlag).HasMaxLength(2);
          builder.Property(c => c.RestrictedFlag).HasMaxLength(2);
          builder.Property(c => c.Backorder).HasMaxLength(2);
          builder.Property(c => c.CommentReq).HasMaxLength(100);
          builder.Property(c => c.CommentCre).HasMaxLength(200);
          builder.Property(c => c.LanguageCode).HasMaxLength(100);
          builder.Property(c => c.StateSuffix).HasMaxLength(4);
          builder.Property(c => c.Creator).HasMaxLength(100);
          builder.Property(c => c.MarginScheme).HasMaxLength(12);
          builder.Property(c => c.CountryOfOrigin).HasMaxLength(4);
          builder.Property(c => c.SKUMarginIND).HasMaxLength(2);
          builder.Property(c => c.SKUFLoorMargin).HasMaxLength(10);
          builder.Property(c => c.GSTCode).HasMaxLength(2);
          builder.Property(c => c.ManufactureName).HasMaxLength(32);
          builder.Property(c => c.HSNCode).HasMaxLength(90);
          builder.Property(c => c.ECCNNo).HasMaxLength(10);
          builder.Property(c => c.RestrictionFlag).HasMaxLength(5);
          builder.Property(c => c.RMA).HasMaxLength(2);
          builder.Property(c => c.EndUserFlag).HasMaxLength(20);
          builder.Property(c => c.ProductCat).HasMaxLength(5);
          builder.Property(c => c.BTAXFlag).HasMaxLength(2);
          builder.Property(c => c.CustCons).HasMaxLength(8);
          builder.Property(c => c.CRC).HasMaxLength(10);
          builder.Property(c => c.CustCode).HasMaxLength(20);
          builder.Property(c => c.StatusCode).HasMaxLength(100);
          builder.Property(c => c.FreightChargeFlag).HasMaxLength(100);
          builder.Property(c => c.SequenceNbr).HasMaxLength(100);         
        }
    }
}