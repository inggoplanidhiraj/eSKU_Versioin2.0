using System;
using System.Runtime.Serialization;

namespace Common.APAC.eSKU.Common.Entities
{
    [DataContract]
    [Serializable]
    public class Vendor
    {
       [DataMember]
       public Int64 VendorID {get;set;}
       [DataMember]
       public String VendorCode {get;set;}
       [DataMember]
       public Int64 VendorGroupID {get;set;}
       [DataMember]
       public String VendorName {get;set;}
       [DataMember]
       public String BranchNumber {get;set;}

       [DataMember]
       public String BuyerCode {get;set;}

       [DataMember]
       public bool CentralizedFlag  {get;set;}
       [DataMember]
       public String Division {get;set;}
       [DataMember]
       public String SubDivision {get;set;}
       [DataMember]
       public DateTime ModifiedDate {get;set;}
       [DataMember]
       public String ModifiedBy {get;set;}
       [DataMember]
       public DateTime CreationDate {get;set;}
       [DataMember]
       public String CreatedBy {get;set;}
       [DataMember]
       public String ProductManager {get;set;}
       [DataMember]
       public String isRestricted {get;set;}
       [DataMember]
       public String ElectronicFlag {get;set;}

       [DataMember]
       public virtual VendorGroup VendorGroup {get;set;}
    }
}