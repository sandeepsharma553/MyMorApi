using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyMorApi.DBModel;
using MyMorApi.Interface;
using MyMorApi.Models;

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
        [Route("Signup")]
        public async Task<IActionResult> Signup(UserModel user)
        {
            var result = await _service.Signup(user);
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
        [Route("UpdateUser")]
        public async Task<IActionResult> UpdateUser(UserModel model)
        {
            var result = await _service.UpdateUser(model);
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
