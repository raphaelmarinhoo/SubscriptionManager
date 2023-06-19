using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SubscriptionManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        [HttpGet]
        public string GetEstado()
        {
            return "Estado Retornado";
        }
    }
}
