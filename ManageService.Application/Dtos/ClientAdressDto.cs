using AutoMapper;
using ManageService.Application.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageService.Application.Dtos
{
    public class ClientAdressDto : BaseDto
    {
        public string Adress { get; set; }
        public int IdCliente { get; set; }
        public bool IsActive { get; set; }


        public virtual ClientDto ClientDto { get; set; }
    }
}
