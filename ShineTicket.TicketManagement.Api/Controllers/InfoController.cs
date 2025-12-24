using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShineTicket.TicketManagement.Application.Features.Events.Queries.GetEventDetail;

namespace ShineTicket.TicketManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfoController : ControllerBase
    {
        private readonly IConfiguration _config;
        public InfoController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet("{key}", Name = "GetKey")]
        public string GetKey(string key)
        {
            
            return _config[key];
        }
    }
}
