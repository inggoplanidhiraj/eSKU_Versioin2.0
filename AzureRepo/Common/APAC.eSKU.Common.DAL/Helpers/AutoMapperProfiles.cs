
using Common.APAC.eSKU.Common.Entities;
using Common.APAC.eSKU.Common.DTO;
using AutoMapper;
using System;
namespace Common.APAC.eSKU.Common.DAL.Helpers
{
    public class AutoMapperProfiles : Profile
    {
         public  AutoMapperProfiles()
         {

          CreateMap<Country, CountryDto>();
          CreateMap<Users, UsersDto>();
           CreateMap<UserRoleMap, UserRoleMapDto>();
          CreateMap<UserRole, UserRoleDto>();
           
         }
    }
}