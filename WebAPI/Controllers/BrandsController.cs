using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _brandService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int brandid)
        {
            var value = _brandService.GetById(brandid);
            if (value.Success)
            {
                return Ok(value);
            }
            return BadRequest(value);


        }


        [HttpPost("add")]
        public IActionResult Add(Brand brand)
        {
            var value = _brandService.Add(brand);
            if (value.Success)
            {
                return Ok(value);
            }
            return BadRequest(value);


        }

        [HttpDelete("delete")]
        public IActionResult Delete(Brand brand)
        {
            var value = _brandService.Delete(brand);
            if (value.Success)
            {
                return Ok(value);
            }
            return BadRequest(value);


        }

        [HttpPut("update")]
        public IActionResult Put(Brand brand)
        {
            var value = _brandService.Update(brand);
            if (value.Success)
            {
                return Ok(value);
            }
            return BadRequest(value);


        }
    }
}
