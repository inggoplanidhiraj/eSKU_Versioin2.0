using System;
using System.Runtime.Serialization;


namespace Common.APAC.eSKU.Common.Entities
{   [DataContract]
    [Serializable]
    public class RequestMode
    {

        [DataMember]
        public Int32 RequestModeID {get;set;}
        [DataMember]
        public String RequestModeName {get;set;} 
    }
}