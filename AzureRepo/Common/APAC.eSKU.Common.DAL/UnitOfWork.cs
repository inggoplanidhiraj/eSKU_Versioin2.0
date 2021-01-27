using Common.APAC.eSKU.Common.DAL.Repositories;
using Common.APAC.eSKU.Common.DAL.RepositoryContracts;
using System;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Common.APAC.eSKU.Common.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly eSKUContext _eSKUContext;
 
        public DbContextTransaction globalTransaction;
        public UnitOfWork(eSKUContext eSKUContext)
        {
            _eSKUContext = eSKUContext;
            InitalizeRepositories();
            SP_Call = new SP_Call(_eSKUContext);
           
        }
     
        public UnitOfWork(eSKUContext eSKUContext, Int32 CommandTimeout)
        {
            eSKUContext.Database.SetCommandTimeout(CommandTimeout);
            _eSKUContext = eSKUContext;
            InitalizeRepositories();
        }

        private void InitalizeRepositories()
        {
            Users = new UsersRepository(_eSKUContext);
            Notifications = new NotificationRepository(_eSKUContext);
            NotificationMap = new NotificationMapRepository(_eSKUContext);
            Products = new ProductRepository(_eSKUContext);
            ProductGroups = new ProductGroupRepository(_eSKUContext);
            ProductStatus = new ProductStatusRepository(_eSKUContext);
            Vendors = new VendorRepository(_eSKUContext);
            VendorGroups = new VendorGroupRepository(_eSKUContext);
            VersionCodes = new VersionCodeRepository(_eSKUContext);
            UploadImpulseLogs = new UploadImpulseLogRepository(_eSKUContext);
            RequestModes = new RequestModeRepository(_eSKUContext);
            Countries = new CountryRepository(_eSKUContext);
            UserRoles = new UserRoleRepository(_eSKUContext);
            UserRoleMap = new UserRoleMapRepository(_eSKUContext);
          
        }
        public void GlobalCommitTransaction()
        {
            if (globalTransaction != null)
                globalTransaction.Commit();
        }
        public void GlobalRollbackTransaction()
        {
            if (globalTransaction != null)
                globalTransaction.Rollback();
        }
        
        public  IUsersRepository  Users { get; private set;}
        public  IUserRoleMapRepository UserRoleMap {get; private set;}
        public  IUserRoleRepository UserRoles {get; private set;}
        public INotificationRepository Notifications {get;private set;}
        public IVendorRepository Vendors {get;private set;}
        public IVendorGroupRepository VendorGroups {get;private set;}
        public IVersionCodeRepository VersionCodes {get;private set;}
        public IProductRepository Products {get;private set;}
        public IProductGroupRepository ProductGroups {get;private set;}
        public ISP_Call SP_Call { get; private set; }
        public IRequestModeRepository RequestModes {get;private set;}

        public INotificationMapRepository NotificationMap {get;private set;}

        public IUploadImpulseLogRepository UploadImpulseLogs {get;private set;}

        public IProductStatusRepository ProductStatus {get;private set;}

        public ICountryRepository Countries {get;private set;}






        
        public async Task<int>  CompleteAsync()
        {
            if (_eSKUContext != null)
                return  await _eSKUContext.SaveChangesAsync();
           
            else
                return 0;
        }

        public void Dispose()
        {
            if (_eSKUContext != null)
                _eSKUContext.Dispose();
          
        }
    }
}
