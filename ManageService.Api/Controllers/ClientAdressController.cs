using AutoMapper;
using ManageService.Api.Infraestructure.Base;
using ManageService.Application.Dtos;
using ManageService.Application.Services.Base;
using ManageService.Application.Services.Contract;
using ManageService.Domain.ManageService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ManageService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientAdressController : BaseApiController<ClientAdress, ClientAdressDto, IServicesBase<ClientAdress>>
    {
        new readonly IClientAdressService _service;
        public ClientAdressController(IClientAdressService service, IServicesBase<ClientAdress> manager, IMapper Mapper) : base(manager, Mapper)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetClientAdressAsync/{idcliente}")]
        public ActionResult GetClientAdressAsync(int idcliente)
        {
            try
            {
                return Ok(_service.GetClientAdressAsync(idcliente));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
