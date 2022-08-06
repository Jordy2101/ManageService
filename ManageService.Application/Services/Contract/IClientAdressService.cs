using ManageService.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageService.Application.Services.Contract
{
    public interface IClientAdressService
    {
        Task<IEnumerable<ClientAdressDto>> GetClientAdressAsync(int idClient);
    }
}
