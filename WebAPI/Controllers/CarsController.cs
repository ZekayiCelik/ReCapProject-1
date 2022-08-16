using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
           var result= _carService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpGet("getcarsbybrandid")]
        public IActionResult GetCarsByBrandId(int brandid)
        {
            var value = _carService.GetCarsByBrandId(brandid);
            if (value.Success)
            {
                return Ok(value);
            }
            return BadRequest(value);


        }

        [HttpGet("getcarsbycolorname")]
        public IActionResult GetCarsByColorName(int colorid)
        {
            var value = _carService.GetCarsByColorName(colorid);
            if (value.Success)
            {
                return Ok(value);
            }
            return BadRequest(value);


        }

        [HttpGet("getdetails")]
        public IActionResult GetDetails()
        {
          var result = _carService.GetCarDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var value = _carService.Add(car);
            if (value.Success)
            {
                return Ok(value);
            }
            return BadRequest(value);


        }

        [HttpDelete("delete")]
        public IActionResult Delete(Car car)
        {
            var value = _carService.Delete(car);
            if (value.Success)
            {
                return Ok(value);
            }
            return BadRequest(value);


        }

        [HttpPut("update")]
        public IActionResult Put(Car car)
        {
            var value = _carService.Update(car);
            if (value.Success)
            {
                return Ok(value);
            }
            return BadRequest(value);


        }
    }
}
