


using Common.APAC.eSKU.Common.DAL.RepositoryContracts;
using Common.APAC.eSKU.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.APAC.eSKU.Common.DAL.Repositories
{
    public class NotificationMapRepository : Repository<NotificationMap>, INotificationMapRepository

    {
        public NotificationMapRepository(eSKUContext eSKUcontext) : base(eSKUcontext)
        {
        }

        public eSKUContext eSKUcontext
        {
            get { return Context as eSKUContext; }
        }
    }

}
