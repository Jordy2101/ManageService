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
    public class ClientRepository : BaseRepository<Client>
    {
        public ClientRepository(ManageServiceContext ctx) : base(ctx)
        {

        }
    }
}
