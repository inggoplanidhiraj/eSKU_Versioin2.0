using System;
using System.Runtime.Serialization;


namespace Common.APAC.eSKU.Common.Entities
{
    [DataContract]
    [Serializable]
    public class UploadImpulseLog
    {   [DataMember]
        public Int64 UploadImpulseLogID {get;set;}
        [DataMember]
        public Int64 ProductID {get;set;}
        [DataMember]
        public DateTime UploadDate {get;set;}
        [DataMember]
        public String UploadStatus {get;set;}

        [DataMember]
        public String ScreenName {get;set;}

        [DataMember]
        public String UploadType {get;set;}
        [DataMember]
        public String FieldName {get;set;}
        [DataMember]
        public String ValueBefore {get;set;}
        [DataMember]
        public String ValueAfter {get;set;}
        [DataMember]
        public String ValueDb {get;set;}
        [DataMember]
        public  virtual Product Product {get;set;}
    }
}