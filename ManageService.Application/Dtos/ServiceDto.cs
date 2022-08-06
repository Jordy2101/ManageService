using ManageService.Application.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageService.Application.Dtos
{
    public class ServiceDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int idcliente { get; set; }
        public int idstatus { get; set; }
        public int idtypeservice { get; set; }
        public int idadress { get; set; }

        public virtual ClientDto ClientDto { get; set; }
        public virtual StatusDto StatusDto { get; set; }
        public virtual TypeServiceDto TypeServiceDto { get; set; }
        public virtual ClientAdressDto ClientAdressDto { get; set; }
    }
}
