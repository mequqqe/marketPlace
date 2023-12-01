using market.Models;
using market.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Web_API_Tutorials.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web_API_Tutorials.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsers _users;
        private readonly IJWTTokenServices _jwttokenservice;

        // GET: api/<UsersController>

        public UsersController(IUsers users, IJWTTokenServices jWTTokenServices)
        {
            _users = users;
            _jwttokenservice = jWTTokenServices;
        }

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_users.GetAll());
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("Authenticate")]
        public IActionResult Authenticate(Users users)
        {
            var token = _jwttokenservice.Authenticate(users);

            if (token == null)
            {
                return Ok(new { Message = "Unauthorized" });
            }

            return Ok(token);
        }
    }
}