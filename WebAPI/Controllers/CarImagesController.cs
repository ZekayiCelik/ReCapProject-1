using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
   
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImageService;

        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }

        [HttpPost("add")] 
        public IActionResult Add( [FromForm] CarImage carImage, [FromForm] IFormFile file)
        {
           var value=  _carImageService.Add(file,carImage);
            if (value.Success)
            {
                return Ok(value);
            }
            return BadRequest(value);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
           var result=  _carImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete([FromForm] CarImage carImage, [FromForm] IFormFile file)
        {
            var value = _carImageService.Delete( carImage);
            if (value.Success)
            {
                return Ok(value);
            }
            return BadRequest(value);
        }

        [HttpPost("update")]
        public IActionResult Update([FromForm] CarImage carImage, [FromForm] IFormFile file)
        {
            var value = _carImageService.Update(file, carImage);
            if (value.Success)
            {
                return Ok(value);
            }
            return BadRequest(value);
        }
    }


}
