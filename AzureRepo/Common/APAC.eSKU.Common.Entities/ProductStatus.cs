using System;
using System.Runtime.Serialization;


namespace Common.APAC.eSKU.Common.Entities
{   
    [DataContract]
    [Serializable]
    public class ProductStatus
    {
        [DataMember]
        public Int32 ProductStatusID {get;set;}
        [DataMember]

        public String ProductStatusName {get;set;} 
    }
}