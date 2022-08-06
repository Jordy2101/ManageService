using AutoMapper;
using ManageService.Api.Infraestructure.Base;
using ManageService.Application.Dtos;
using ManageService.Application.Services.Base;
using ManageService.Application.Services.Contract;
using ManageService.Common.Filter;
using ManageService.Domain.ManageService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ManageService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : BaseApiController<Client, ClientDto, IServicesBase<Client>>
    {
        new readonly IClientService _service;
        public ClientController(IClientService service, IServicesBase<Client> manager, IMapper Mapper) : base(manager, Mapper)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetPaged")]
        public ActionResult GetPaged([FromQuery] ClientFilter filter)
        {
            try
            {
                return Ok(_service.GetPaged(filter));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("CreateClient")]
        public ActionResult CreateClient([FromBody] CreateClient data)
        {
            try
            {
                _service.CreateClient(data);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
