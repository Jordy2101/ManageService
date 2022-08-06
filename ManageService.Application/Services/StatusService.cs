using AutoMapper;
using ManageService.Application.Services.Base;
using ManageService.DataAccess.Repositories.Base;
using ManageService.Domain.ManageService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageService.Application.Services
{
    public class StatusService : ServicesBase<Status>
    {
        readonly IMapper mapper;
        public StatusService(IBaseRepository<Status> repository, IMapper _mapper) : base(repository)
        {
            mapper = _mapper;
        }
    }
}
