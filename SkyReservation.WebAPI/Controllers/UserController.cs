using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkyReservation.WebAPI.Dtos.User;
using SkyReservation.WebAPI.Interface;
using SkyReservation.WebAPI.Models;

namespace SkyReservation.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiVersion(1)]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            this._userService = userService;
        }
        [HttpPost]
        public IActionResult Add(AddUserRequest request)
        {
            //Dependency Entites And Dtos
            var result = new User();
            var addUserResponce = result.Add(request ?? new AddUserRequest());
            return Ok(addUserResponce);
        }
    }
}
