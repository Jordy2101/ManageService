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
    public class TypeServiceService : ServicesBase<TypeService>
    {
        readonly IMapper mapper;
        public TypeServiceService(IBaseRepository<TypeService> repository, IMapper _mapper) : base(repository)
        {
            mapper = _mapper;
        }
    }
}
