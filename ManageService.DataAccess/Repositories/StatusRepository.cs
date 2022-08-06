using ManageService.DataAccess.DBContexts;
using ManageService.DataAccess.Repositories.Base;
using ManageService.Domain.ManageService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageService.DataAccess.Repositories
{
    public class StatusRepository : BaseRepository<Status>
    {
        public StatusRepository(ManageServiceContext ctx) : base(ctx)
        {

        }
    }
}
