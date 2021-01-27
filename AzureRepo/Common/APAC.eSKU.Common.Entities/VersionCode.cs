using System;
using System.Runtime.Serialization;

namespace Common.APAC.eSKU.Common.Entities
{   
    [DataContract]
    [Serializable]
    public class VersionCode
    {
        [DataMember]
        public Int32 VersionCodeID {get;set;}
        [DataMember]
        public String VersionCodeName {get;set;}
        [DataMember]
        public String VersionCodeDesc {get;set;}
        [DataMember]
        public String Description {get;set;}
        [DataMember]
        public String Suffix {get;set;}  
    }
}