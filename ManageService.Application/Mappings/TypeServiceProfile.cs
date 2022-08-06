using AutoMapper;
using ManageService.Application.Dtos;
using ManageService.Domain.ManageService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageService.Application.Mappings
{
    public class TypeServiceProfile : Profile
    {
        public TypeServiceProfile()
        {
            CreateMap<TypeService, TypeServiceDto>().ReverseMap();
        }
    }
}
