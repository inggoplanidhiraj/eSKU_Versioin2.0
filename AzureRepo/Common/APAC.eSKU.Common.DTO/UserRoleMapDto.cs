
using System;
using System.Runtime.Serialization;
namespace Common.APAC.eSKU.Common.DTO
{
    public class UserRoleMapDto
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
        public  CountryDto Country {get;set;}

         [DataMember]

         public  UserRoleDto UserRole {get;set;}

         [DataMember]

         public  UsersDto users {get;set;}
    }
}