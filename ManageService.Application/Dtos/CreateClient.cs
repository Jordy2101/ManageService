using ManageService.Domain.ManageService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageService.Application.Dtos
{
    public class CreateClient
    {
        public ClientDto ClientDto { get; set; }
        public List<ClientAdress> ListAdress { get; set; }
    }
}
