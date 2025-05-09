using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyMorApi.Interface;
using MyMorApi.Model;

namespace MyMorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        readonly IReportService _service;
        public ReportController(IReportService service)
        {
            _service = service;
        }
        [HttpPost]
        [Route("Get")]
        public async Task<IActionResult> Get(ReportModel model)
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
        public async Task<IActionResult> Create(ReportModel model)
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
        public async Task<IActionResult> Update(ReportModel model)
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
        public async Task<IActionResult> Delete(ReportModel model)
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
