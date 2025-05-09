using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyMorApi.Model;
using MyMorApi.Interface;

namespace MyMorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingRoomController : ControllerBase
    {
        readonly IBookingRoomService _service;
        public BookingRoomController(IBookingRoomService service)
        {
            _service = service;
        }
        [HttpPost]
        [Route("Get")]
        public async Task<IActionResult> Get(BookingRoomModel model)
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
        public async Task<IActionResult> Create(BookingRoomModel model)
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
        public async Task<IActionResult> Update(BookingRoomModel model)
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
        public async Task<IActionResult> Delete(BookingRoomModel model)
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
