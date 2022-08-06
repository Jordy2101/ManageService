using AutoMapper;
using ManageService.Application.Dtos;
using ManageService.Application.Services.Base;
using ManageService.Application.Services.Contract;
using ManageService.Common.Contans;
using ManageService.Common.Filter;
using ManageService.Common.Paged;
using ManageService.DataAccess.Repositories.Base;
using ManageService.Domain.ManageService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageService.Application.Services
{
    public class ClientService : ServicesBase<Client>, IClientService
    {
        readonly IMapper mapper;
        readonly IBaseRepository<ClientAdress> _clienteAdressRepository;

        public ClientService(IBaseRepository<Client> repository, IMapper _mapper, IBaseRepository<ClientAdress> clienteAdressRepository) : base(repository)
        {
            mapper = _mapper;
            _clienteAdressRepository = clienteAdressRepository;
        }

        public  void CreateClient(CreateClient client)
        {
            try
            {
                var adress = new List<ClientAdress>();

                var mapClient = mapper.Map<Client>(client.ClientDto);

                var Exist = base.Exist(c=> c.Name == mapClient.Name.Trim());

                if (Exist)
                    throw new ArgumentException(MessageCodes.RecordExist);

                mapClient.IsActive = true;

                var id = base.Create(mapClient);

                foreach (var item in client.ListAdress)
                {
                    adress.Add(new ClientAdress() 
                    {
                        IsActive = true,
                        idcliente = id,
                        Adress = item.Adress
                    });
                }

                _clienteAdressRepository.CreateRange(adress);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public Task<PagedList<Client>> GetPaged(ClientFilter filter)
        {
            try
            {
                var data = base.FindAll();

                data = filter.keyword is not null ? data.Where(c => c.Name.Contains(filter.keyword)) : data;

                data = !data.Any() ? throw new ArgumentException(MessageCodes.EmptyCollections) : data;

                var pagelist = PagedList<Client>.Create(data, filter.PageNumber, filter.PageSize);

                return Task.FromResult(pagelist);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
