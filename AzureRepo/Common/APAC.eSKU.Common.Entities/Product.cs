using System;
using System.Runtime.Serialization;

namespace Common.APAC.eSKU.Common.Entities
{
    [DataContract]
    [Serializable]
    public class Product
    {    [DataMember]
         public Int64 ProductID {get;set;}
        [DataMember]
         public String UserID {get;set;}
        [DataMember] 
         public Int32 CountryID {get;set;}
        [DataMember]
         public String Description {get;set;}
        [DataMember] 
         public String Description2 {get;set;}
        [DataMember] 
         public Int32 ProductGroupID {get;set;}
        [DataMember]
         public String CPUCode {get;set;}
        [DataMember]
         public String MediaCode{get;set;}
        [DataMember]
         public Int32 VersionCodeID{get;set;}
   
        [DataMember]
         public String VendorPartNumber {get;set;}
        [DataMember]
         public Int64 VendorID {get;set;}
        [DataMember]
         public String Category {get;set;}
        [DataMember]
         public String Catalog {get;set;}
        [DataMember]
         public String Weight {get;set;}
        [DataMember]
         public Double High {get;set;}
        [DataMember]
         public Double Length{get;set;}
        [DataMember]
         public Double Width {get;set;}
        [DataMember]
         public String SemiConFlag {get;set;}
        [DataMember]
         public String SKU {get;set;}
        [DataMember]
         public String RequestStatus {get;set;}
        [DataMember]
         public Double BasePrice{get;set;}
        [DataMember]
         public Double MiscCost{get;set;}
        [DataMember]
         public String DutyCode {get;set;}
        [DataMember]
         public String TaxCode{get;set;}
        [DataMember]
         public String VatCode{get;set;}
        [DataMember]
         public String CurrencyCode{get;set;}
        [DataMember]
         public String ClassCode {get;set;}
        [DataMember]
         public Double RetailPrice {get;set;}
        [DataMember]
         public Double DealerPrice {get;set;}
        [DataMember]
         public String ItemTypeCode {get;set;}
        [DataMember]
         public String ELectronicFlag {get;set;}
        [DataMember]
         public String SerialNbrFlag {get;set;}
        [DataMember]
         public String RestrictedFlag {get;set;}
         [DataMember]
         public String Backorder {get;set;}
        [DataMember]
         public String CommentReq {get;set;}
        [DataMember]
         public String CommentCre {get;set;}
        [DataMember]
         public String LanguageCode {get;set;}
        [DataMember] 
         public String StateSuffix {get;set;}
        [DataMember]
         public Int32 RequestModeID {get;set;}
        [DataMember]
         public String Creator {get;set;}
        [DataMember]
         public String MarginScheme{get;set;}
        [DataMember]
         public Single ReplacementCost  {get;set;}
        [DataMember]  
         public Single AverageCost  {get;set;}
        [DataMember]  
         public Single CurrentRetailPrice  {get;set;}
        [DataMember]  
         public Single CurrentDealerPrice  {get;set;}
        [DataMember]  
         public Single CurrentCol1Price  {get;set;}
        [DataMember]  
         public Single CurrentCol2Price  {get;set;}
        [DataMember]  
         public Single CurrentCol3Price  {get;set;}
        [DataMember]  
         public Single CurrentCol4Price  {get;set;}
        [DataMember]  
         public Single CurrentCol5Price  {get;set;}
        [DataMember]  
         public Single CurrentCol6Price  {get;set;}
        [DataMember]  
         public Single CurrentCol7Price  {get;set;}
        [DataMember]  
         public Single Discount  {get;set;}

        [DataMember]  
         public  String  CountryOfOrigin {get;set;}
        [DataMember]  
         public  String  SKUMarginIND {get;set;}
        [DataMember]  
         public  String  SKUFLoorMargin {get;set;}
        [DataMember]  
         public  String  GSTCode {get;set;}
        [DataMember]  
         public  String  ManufactureName {get;set;}
        [DataMember]  
         public  String  HSNCode {get;set;}
        [DataMember]  
         public  String  ECCNNo {get;set;}
        [DataMember]  
         public  String  RestrictionFlag {get;set;}
        [DataMember]  
         public  String  RMA {get;set;}
        [DataMember]  
         public  String  EndUserFlag {get;set;}
        [DataMember]  
         public  String  ProductCat {get;set;}
        [DataMember]  
         public  String  BTAXFlag {get;set;}
        [DataMember]  
         public  String  CustCons {get;set;}
        [DataMember]  
         public  String  CRC {get;set;}
        [DataMember]  
         public  String  CustCode {get;set;}
        [DataMember]
         public Int32 ProductStatusID {get;set;}
       
        [DataMember]
         public Single AdjustedCost {get;set;}
        [DataMember]
         public Single MiscellaneuousCost {get;set;}
        [DataMember]
         public DateTime RequestDate {get;set;}
        [DataMember] 
         public DateTime CreationDate {get;set;}
        [DataMember]
         public DateTime LastModificationDate {get;set;}
        [DataMember]
         public Boolean DistributedFlag {get;set;}
        [DataMember]  
         public String StatusCode {get;set;}
        [DataMember]  
         public String FreightChargeFlag {get;set;}
        [DataMember]  
         public String SequenceNbr {get;set;}
       
        [DataMember]
        public virtual Users Users {get;set;}
        [DataMember]
        public virtual Country Country {get;set;} 
        [DataMember]
        public virtual RequestMode RequestMode {get;set;}
        [DataMember]

        public virtual ProductStatus ProductStatus {get;set;}
        [DataMember]

        public virtual ProductGroup ProductGroup {get;set;}

        [DataMember]
        public virtual VersionCode VersionCode {get;set;}
        [DataMember]

        public virtual Vendor Vendor {get;set;}
        


    }
}