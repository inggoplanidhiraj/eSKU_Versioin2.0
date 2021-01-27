using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Common.APAC.eSKU.Common.DAL;
using Common.APAC.eSKU.Common.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Common.APAC.eSKU.Common.Entities;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;



namespace Client.API.APAC.eSKU.Client.API.Controllers
{

    public class LoginController : BaseAPIController
    {
          public LoginController(IUnitOfWork unitOfWork,  IHostEnvironment hostingEnvironment, IConfiguration config,IHttpContextAccessor httpContextAccessor,IMapper mapper) : base(unitOfWork,  hostingEnvironment,config,httpContextAccessor,mapper)
        {
            
        }

        
        [HttpGet]
       [Route("Login/Index")]
       
        public async  Task<ActionResult<IEnumerable<Users>>> Index()
        {
            //string WindowsID = "inchas05";
        
            //string WindowsID =   _httpContextAccessor.HttpContext.User.Identity.Name.ToString().Replace("CORPORATE\\", "").ToLower();  
            string WindowsID = "inchas05";
            var userDetails = await _unitOfWork.Users.FindAllAsync(e => e.WindowsID == WindowsID,e => e.Country);
            var usersDto =  _mapper.Map<IEnumerable<UsersDto>>(userDetails);
            // var userDetails = await _unitOfWork.Users.FindAllAsync(e => e.WindowsID == WindowsID);
            if(usersDto.Count() != 0)
             return Ok(usersDto);
            else  
             return NotFound(); 

        }

       [HttpPost]
       [Route("Login/SetUserDetails")]
       
        public async  Task<ActionResult<IEnumerable<UserRoleMap>>>  SetUserDetails(int id)
        {
            //string WindowsID = "inchas05";
        
            //string WindowsID =   _httpContextAccessor.HttpContext.User.Identity.Name.ToString().Replace("CORPORATE\\", "").ToLower();  
        
            var userDetails = await _unitOfWork.Users.FindSingleAsync(e => e.UsersID == id,e => e.Country);
            var usersDto =  _mapper.Map<UsersDto>(userDetails);
            var rolemap = await _unitOfWork.UserRoleMap.FindAllAsync(e => e.UsersID == id,e =>e.Country,e => e.UserRole);
              var rolemapDto =  _mapper.Map<IEnumerable<UserRoleMapDto>>(rolemap);
            // _httpContextAccessor.HttpContext.Session.SetString("SessionUser",usersDto.UserName);
            // _httpContextAccessor.HttpContext.Session.SetString("SessionEmail",usersDto.Email);
            // _httpContextAccessor.HttpContext.Session.SetString("SessionSuperAdmin",usersDto.SuperAdmin.ToString());
            // _httpContextAccessor.HttpContext.Session.SetString("SessionCompany",usersDto.Country.CountryCode);
            // IEnumerable<string> AdminCountries =rolemapDto.Where(e => e.UserRole.UserRoleName == "Administrator").Select(e => e.Country.CountryCode);
            //  IEnumerable<string> CreatorCountries =rolemapDto.Where(e => e.UserRole.UserRoleName == "Requestor").Select(e => e.Country.CountryCode);
            //   IEnumerable<string> RequestorCountries =rolemapDto.Where(e => e.UserRole.UserRoleName == "Creator").Select(e => e.Country.CountryCode);
            // if(AdminCountries.Any()){
            // _httpContextAccessor.HttpContext.Session.SetString("SessionAdministrator",String.Join(",",AdminCountries));

            // } 
            // if(CreatorCountries.Any()){
            // _httpContextAccessor.HttpContext.Session.SetString("SessionCreator",String.Join(",",CreatorCountries));

            // } 
            // if(RequestorCountries.Any()){
            // _httpContextAccessor.HttpContext.Session.SetString("SessionRequestor",String.Join(",",RequestorCountries));

            // } 
           
             userDetails.LastLoginDate = DateTime.Now;
    
    
            _unitOfWork.Users.Update(userDetails);
             await _unitOfWork.CompleteAsync();
             return Ok(rolemapDto);
            // var userDetails = await _unitOfWork.Users.FindAllAsync(e => e.WindowsID == WindowsID);
            
           
        }

    }
}