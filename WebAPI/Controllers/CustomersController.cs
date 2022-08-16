using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var value = _customerService.GetAll();
            if (value.Success)
            {
                return Ok(value);

            }
            return BadRequest(value);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int customerid)
        {
            var value = _customerService.GetById(customerid);
            if (value.Success)
            {
                return Ok(value);
            }
            return BadRequest(value);


        }

        [HttpGet("getdetails")]
        public IActionResult GetCarsByColorName()
        {
            var value = _customerService.GetCustomerDetails();
            if (value.Success)
            {
                return Ok(value);
            }
            return BadRequest(value);


        }

        
        [HttpPost("add")]
        public IActionResult Add(Customer customer)
        {
            var value = _customerService.Add(customer);
            if (value.Success)
            {
                return Ok(value);
            }
            return BadRequest(value);


        }

        [HttpDelete("delete")]
        public IActionResult Delete(Customer customer)
        {
            var value = _customerService.Delete(customer);
            if (value.Success)
            {
                return Ok(value);
            }
            return BadRequest(value);


        }

        [HttpPut("update")]
        public IActionResult Put(Customer customer)
        {
            var value = _customerService.Update(customer);
            if (value.Success)
            {
                return Ok(value);
            }
            return BadRequest(value);


        }
    }
}
