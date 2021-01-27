

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Common.APAC.eSKU.Common.DAL.Helpers;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Common.APAC.eSKU.Common.DAL;
namespace Client.API.APAC.eSKU.Client.API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
            
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<eSKUContext>(option => option.UseSqlServer(config.GetConnectionString("eSKUContext")));
            return services;
        }
    }
}