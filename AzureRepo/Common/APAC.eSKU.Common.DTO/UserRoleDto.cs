
using System;
using System.Runtime.Serialization;
namespace Common.APAC.eSKU.Common.DTO
{
    public class UserRoleDto
    {
         [DataMember]
        public int UserRoleID {get;set;}
        [DataMember]
        public string UserRoleName {get;set;}
        
    }
}