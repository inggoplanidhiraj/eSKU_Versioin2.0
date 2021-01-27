using System;
using System.Runtime.Serialization;

namespace Common.APAC.eSKU.Common.Entities
{

    [DataContract]
    [Serializable]
    public class NotificationMap
    {   [DataMember]
        public Int32 NotificationMapID {get;set;}
        [DataMember]
        public Int32 NotificationID {get;set;}
        [DataMember]
        public String UserID {get;set;}
        [DataMember]
        public Int32 CountryID {get;set;}
        [DataMember]
        public virtual Notification Notification {get;set;}

        [DataMember]
        public virtual Country Country {get;set;}

         [DataMember]
        public virtual Users User {get;set;}


    }
}