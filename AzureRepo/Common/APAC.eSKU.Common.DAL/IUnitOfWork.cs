using Common.APAC.eSKU.Common.DAL.RepositoryContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.APAC.eSKU.Common.DAL
{
    public interface IUnitOfWork : IDisposable
    {
       ISP_Call SP_Call { get; }
       IUsersRepository Users  {get;}
       INotificationRepository Notifications  {get;}
       INotificationMapRepository NotificationMap {get;}
       IProductRepository Products {get;}
       IProductGroupRepository ProductGroups {get;}
       IProductStatusRepository ProductStatus {get;}
       IVendorRepository Vendors  {get;}
       IVendorGroupRepository VendorGroups {get;}
       IVersionCodeRepository VersionCodes {get;}
       IUploadImpulseLogRepository UploadImpulseLogs {get;}
       IRequestModeRepository RequestModes {get;}
       ICountryRepository Countries  {get;}
       IUserRoleRepository UserRoles {get;}
       IUserRoleMapRepository UserRoleMap  {get;}
       Task<int> CompleteAsync();
    }
}
