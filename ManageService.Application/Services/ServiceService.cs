using AutoMapper;
using ManageService.Application.Dtos;
using ManageService.Application.Services.Base;
using ManageService.Application.Services.Contract;
using ManageService.Common.Contans;
using ManageService.Common.Filter;
using ManageService.Common.Paged;
using ManageService.DataAccess.Repositories.Base;
using ManageService.Domain.ManageService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageService.Application.Services
{
    public class ServiceService : ServicesBase<Service>, IServiceService
    {
        readonly IMapper mapper;
        public ServiceService(IBaseRepository<Service> repository, IMapper _mapper) : base(repository)
        {
            mapper = _mapper;
        }

        public Task<PagedList<Service>> GetPaged(ServiceFilter filter)
        {
            try
            {
                var data = base.FindAll();

                data = filter.keyword is not null ? data.Where(c => c.Name.Contains(filter.keyword)) : data;

                data = !data.Any() ? throw new ArgumentException(MessageCodes.EmptyCollections) : data;

                var pagelist = PagedList<Service>.Create(data, filter.PageNumber, filter.PageSize);

                return Task.FromResult(pagelist);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public void CreateService(Service service)
        {
            try
            {
                base.Create(service);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
