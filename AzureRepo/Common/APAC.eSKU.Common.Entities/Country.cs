using System;
using System.Runtime.Serialization;
namespace Common.APAC.eSKU.Common.Entities
{   [DataContract]
    [Serializable]
    public class Country

    {  
        [DataMember]
        public Int32 CountryID {get;set;}
        [DataMember]
        public String CountryName {get;set;}
        [DataMember]
        public String CountryCode {get;set;}

    }
}
