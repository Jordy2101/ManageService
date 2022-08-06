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
    public class ClientAdressProfile : Profile
    {
        public ClientAdressProfile()
        {
            CreateMap<ClientAdress, ClientAdressDto>().ForMember(c => c.ClientDto, opt => opt.MapFrom(c => c.Client)).ReverseMap();
        }
    }
}
