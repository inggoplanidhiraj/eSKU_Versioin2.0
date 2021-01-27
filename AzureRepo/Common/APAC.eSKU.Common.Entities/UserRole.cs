using System;
using System.Runtime.Serialization;


namespace Common.APAC.eSKU.Common.Entities
{ 
    [DataContract]
    [Serializable]
    public class UserRole
    {   [DataMember]
        public int UserRoleID {get;set;}
        [DataMember]
        public string UserRoleName {get;set;}

        
    }
}