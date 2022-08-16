using Business.Abstract;
using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _userService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int userid)
        {
            var value = _userService.GetById(userid);
            if (value.Success)
            {
                return Ok(value);
            }
            return BadRequest(value);


        }



        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            var value = _userService.Add(user);
            if (value.Success)
            {
                return Ok(value);
            }
            return BadRequest(value);


        }

        [HttpDelete("delete")]
        public IActionResult Delete(User user)
        {
            var value = _userService.Delete(user);
            if (value.Success)
            {
                return Ok(value);
            }
            return BadRequest(value);


        }

        [HttpPut("update")]
        public IActionResult Put(User user)
        {
            var value = _userService.Update(user);
            if (value.Success)
            {
                return Ok(value);
            }
            return BadRequest(value);


        }
    }
}
