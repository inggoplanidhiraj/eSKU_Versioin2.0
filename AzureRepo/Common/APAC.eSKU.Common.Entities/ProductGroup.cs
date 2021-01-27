using System;
using System.Runtime.Serialization;


namespace Common.APAC.eSKU.Common.Entities
{
    [DataContract]
    [Serializable]
    public class ProductGroup
    {   [DataMember]
        public Int32 ProductGroupID {get;set;}
        [DataMember]
        public String ProductGroupCode {get;set;}
        [DataMember]
        public String ProductGroupName {get;set;}
        [DataMember]
        public String ProductGroupAbreviation {get;set;}
        [DataMember]
        public String Invisible {get;set;} 
    }
}