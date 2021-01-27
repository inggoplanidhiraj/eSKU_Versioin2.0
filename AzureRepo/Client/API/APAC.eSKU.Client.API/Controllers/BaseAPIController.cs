using Common.APAC.eSKU.Common.DAL;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;

namespace Client.API.APAC.eSKU.Client.API.Controllers
{
    public class BaseAPIController : ControllerBase
    {

        protected readonly IUnitOfWork _unitOfWork;
        
        protected readonly IHostEnvironment _hostingEnvironment;
        protected readonly IConfiguration _config;
        protected readonly IMapper _mapper;
        protected readonly  IHttpContextAccessor _httpContextAccessor;
        public BaseAPIController(IUnitOfWork unitOfWork,  IHostEnvironment hostingEnvironment, IConfiguration config,IHttpContextAccessor httpContextAccessor,IMapper mapper)
        {
            _config = config;
            _hostingEnvironment = hostingEnvironment;
            
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;

        }
        //   protected void GetUser(out string WindowsID)
        //   {
        //       WindowsID = User.Identity.Name.ToString().Replace("CORPORATE\\", "").ToLower();
        //   }
    }
}