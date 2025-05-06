using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyMorApi.DBModel;
using MyMorApi.Interface;

namespace MyMorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;

        }
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(Login user)
        {
            var result = await _service.Login(user);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
    }
}
