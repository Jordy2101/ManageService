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
    public class ServiceController : BaseApiController<Service, ServiceDto, IServicesBase<Service>>
    {
        new readonly IServiceService _service;
        public ServiceController(IServiceService service, IServicesBase<Service> manager, IMapper Mapper) : base(manager, Mapper)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetPaged")]
        public ActionResult GetPaged([FromQuery] ServiceFilter filter)
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
        [Route("CreateService")]
        public ActionResult CreateService([FromBody] Service filter)
        {
            try
            {
                _service.CreateService(filter);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
