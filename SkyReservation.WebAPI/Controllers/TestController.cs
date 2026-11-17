using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace SkyReservation.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    [ApiVersion("1.2")]
    public class TestController : ControllerBase
    {
        //Method --> Action - Service
        [HttpPost]
        public string AddTest(string Description , string Name)
        {
        return Description + Name;
        }
        [HttpGet]
        public string GetTest(string Description, string Name)
        {
            return Description + Name;
        }
    }
}
