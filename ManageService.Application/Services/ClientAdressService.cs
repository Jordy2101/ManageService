using AutoMapper;
using ManageService.Application.Dtos;
using ManageService.Application.Services.Base;
using ManageService.Application.Services.Contract;
using ManageService.DataAccess.Repositories.Base;
using ManageService.Domain.ManageService;

namespace ManageService.Application.Services
{
    public class ClientAdressService : ServicesBase<ClientAdress>, IClientAdressService
    {
        readonly IMapper mapper;
        public ClientAdressService(IBaseRepository<ClientAdress> repository, IMapper _mapper) : base(repository)
        {
            mapper = _mapper;
        }

        public Task<IEnumerable<ClientAdressDto>> GetClientAdressAsync(int idClient)
        {
            try
            {
                var data = base.FindByCondition(c=> c.idcliente == idClient && c.IsActive).ToList();

                var map = mapper.Map<IEnumerable<ClientAdressDto>>(data);

                return Task.FromResult(map);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
