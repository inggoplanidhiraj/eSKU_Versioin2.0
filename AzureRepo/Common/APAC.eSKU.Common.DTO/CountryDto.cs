
using System;
using System.Runtime.Serialization;
namespace Common.APAC.eSKU.Common.DTO
{
    public class CountryDto
    {
         [DataMember]
        public Int32 CountryID {get;set;}
        [DataMember]
        public String CountryName {get;set;}
        [DataMember]
        public String CountryCode {get;set;}

    }
}