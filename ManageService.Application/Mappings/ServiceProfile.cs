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
    public class ServiceProfile : Profile
    {
        public ServiceProfile()
        {
            CreateMap<Service, ServiceDto>().ForMember(c => c.ClientDto, opt => opt.MapFrom(c => c.Client))
                                            .ForMember(c=> c.StatusDto, opt=> opt.MapFrom(c=> c.Status))
                                            .ForMember(c=> c.ClientAdressDto, opt => opt.MapFrom(c=> c.ClientAdress))
                                            .ForMember(c=> c.TypeServiceDto, opt=> opt.MapFrom(c=> c.TypeService)).ReverseMap();
        }
    }
}
