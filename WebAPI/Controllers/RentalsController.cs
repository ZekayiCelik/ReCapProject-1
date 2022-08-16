using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService;

        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _rentalService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int rentalid)
        {
            var value = _rentalService.GetById(rentalid);
            if (value.Success)
            {
                return Ok(value);
            }
            return BadRequest(value);


        }



        [HttpPost("add")]
        public IActionResult Add(Rental rental)
        {
            var value = _rentalService.Add(rental);
            if (value.Success)
            {
                return Ok(value);
            }
            return BadRequest(value);


        }

        [HttpDelete("delete")]
        public IActionResult Delete(Rental rental)
        {
            var value = _rentalService.Delete(rental);
            if (value.Success)
            {
                return Ok(value);
            }
            return BadRequest(value);


        }

        [HttpPut("update")]
        public IActionResult Put(Rental rental)
        {
            var value = _rentalService.Update(rental);
            if (value.Success)
            {
                return Ok(value);
            }
            return BadRequest(value);


        }
    }
}
