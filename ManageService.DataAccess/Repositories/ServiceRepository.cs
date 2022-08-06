using ManageService.DataAccess.DBContexts;
using ManageService.DataAccess.Repositories.Base;
using ManageService.Domain.ManageService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageService.DataAccess.Repositories
{
    public class ServiceRepository : BaseRepository<Service>
    {
        public ServiceRepository(ManageServiceContext ctx) : base(ctx)
        {

        }

        public override IQueryable<Service> FindAll()
        {
            return base.FindAll().Include(c=> c.ClientAdress).Include(c=> c.Client).Include(c=> c.Status).Include(c=> c.TypeService);
        }
    }
}
 