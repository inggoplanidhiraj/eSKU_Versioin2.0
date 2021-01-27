using System;
using System.Runtime.Serialization;


namespace Common.APAC.eSKU.Common.Entities
{
    [DataContract]
    [Serializable]
    public class UserRoleMap
    {
        [DataMember]
        public Int32 UserRoleMapID {get;set;}

        [DataMember]
        public Int32 UsersID {get;set;}

         [DataMember]
        public Int32 UserRoleID {get;set;}

        [DataMember]
        public Int32 CountryID {get;set;}

        [DataMember]
        public virtual Country Country {get;set;}

         [DataMember]

         public virtual UserRole UserRole {get;set;}

         [DataMember]

         public virtual Users users {get;set;}

    }
}