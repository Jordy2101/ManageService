using ManageService.DataAccess.DBContexts;
using ManageService.DataAccess.Repositories.Base;
using ManageService.Domain.ManageService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ManageService.DataAccess.Repositories
{
    public class ClientAdressRepository : BaseRepository<ClientAdress>
    {
        public ClientAdressRepository(ManageServiceContext ctx) : base(ctx)
        {

        }

        public override IQueryable<ClientAdress> FindByCondition(Expression<Func<ClientAdress, bool>> expression)
        {
            return base.FindByCondition(expression).Include(c=> c.Client);
        }
    }
}
