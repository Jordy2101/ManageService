using ManageService.Application.Dtos;
using ManageService.Common.Filter;
using ManageService.Common.Paged;
using ManageService.Domain.ManageService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageService.Application.Services.Contract
{
    public interface IServiceService
    {
        Task<PagedList<Service>> GetPaged(ServiceFilter filter);
        void CreateService(Service service);
    }
}
