using System;

using System.Runtime.Serialization;
namespace Common.APAC.eSKU.Common.DTO
{
    public class UsersDto
    
    {
         [DataMember]
        public Int32 UsersID {get;set;}
        [DataMember]

        public String WindowsID {get;set;}
        [DataMember]

        public Int32 CountryID {get;set;}
       

        [DataMember]

        public String ContactNumber {get;set;}
        [DataMember]

        public String Department {get;set;}
        [DataMember]

        public String Email {get;set;}
        [DataMember]

        public String UserName {get;set;}
        [DataMember]
        public Int32 SupervisorID {get;set;}
        [DataMember]
        public DateTime LastLoginDate {get;set;}
        [DataMember]
        public DateTime CreationDate {get;set;}
        [DataMember]
        public String CreatedBy {get;set;}
        [DataMember]
        public String Comment {get;set;}
        [DataMember]
        public Boolean isActive {get;set;}
        [DataMember]
        public DateTime TerminationDate {get;set;}
          [DataMember]

        public Boolean SuperAdmin {get;set;}
         [DataMember]
        public  CountryDto Country {get;set;}

    }
}