using AutoMapper;
using ManageService.Api.Infraestructure.Base;
using ManageService.Application.Dtos;
using ManageService.Application.Services.Base;
using ManageService.Domain.ManageService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ManageService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : BaseApiController<Status, StatusDto, IServicesBase<Status>>
    {
        public StatusController(IServicesBase<Status> manager, IMapper Mapper) : base(manager, Mapper)
        {

        }
    }
}
