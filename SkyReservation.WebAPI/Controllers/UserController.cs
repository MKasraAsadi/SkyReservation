using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkyReservation.WebAPI.Dtos.User;

namespace SkyReservation.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public Task<IActionResult> Add(AddUserRequest request)
        {
            throw new Exception();
        }
    }
}
