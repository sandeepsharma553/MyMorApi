using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyMorApi.Interface;
using MyMorApi.Model;

namespace MyMorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaintenanceController : ControllerBase
    {
        readonly IMaintenanceService _service;
        public MaintenanceController(IMaintenanceService service)
        {
            _service = service;
        }
        [HttpPost]
        [Route("Get")]
        public async Task<IActionResult> Get(MaintenanceModel model)
        {
            var result = await _service.Get(model);
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
        [Route("Create")]
        public async Task<IActionResult> Create(MaintenanceModel model)
        {
            var result = await _service.Create(model);
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
        [Route("Update")]
        public async Task<IActionResult> Update(MaintenanceModel model)
        {
            var result = await _service.Update(model);
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
        [Route("Delet")]
        public async Task<IActionResult> Delete(MaintenanceModel model)
        {
            var result = await _service.Delete(model);
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
