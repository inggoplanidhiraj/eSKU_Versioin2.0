
using Common.APAC.eSKU.Common.DAL.RepositoryContracts;
using Common.APAC.eSKU.Common.Entities;

namespace Common.APAC.eSKU.Common.DAL.Repositories
{
    public class VendorGroupRepository : Repository<VendorGroup>, IVendorGroupRepository

    {
        public VendorGroupRepository(eSKUContext eSKUcontext) : base(eSKUcontext)
        {
        }

        public eSKUContext eSKUcontext
        {
            get { return Context as eSKUContext; }
        }
    }

}
