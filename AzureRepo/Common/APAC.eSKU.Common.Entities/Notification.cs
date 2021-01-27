using System;
using System.Runtime.Serialization;
namespace Common.APAC.eSKU.Common.Entities

{   
    [DataContract]
    [Serializable]
    public class Notification
    {

        [DataMember]
        public Int32 NotificationID {get;set;}

        [DataMember]
        public String NotificationDesc {get;set;}
        
    }
}