using System;
using System.Runtime.Serialization;


namespace Common.APAC.eSKU.Common.Entities
{   
    [DataContract]
    [Serializable]
    public class VendorGroup
    {   
        [DataMember]
        public Int64 VendorGroupID {get;set;}
        [DataMember]
        public String VendorGroupName {get;set;}
        [DataMember]
        public String VendorGroupCode {get;set;}
        [DataMember]
        public String SKUPrefix {get;set;}
        [DataMember]
        public String CurrentSequentialNumber {get;set;}

    }
}