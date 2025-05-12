using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyMorApi.DBModel;
using MyMorApi.Interface;
using MyMorApi.Models;

namespace MyMorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        readonly IAuthService _service;
        public AuthController(IAuthService service)
        {
            _service = service;

        }
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(LoginModel login)
        {
            var result = await _service.Login(login);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpPost]
        [Route("VerifyEmail")]
        public async Task<IActionResult> VerifyEmail(UserModel model)
        {
            var result = await _service.VerifyEmail(model);
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
