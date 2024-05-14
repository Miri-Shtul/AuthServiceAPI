using Microsoft.AspNetCore.Mvc;
using AuthServiceAPI.Models;
using AuthServiceAPI.Services;

namespace AuthServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly TokenService _tokenService;

        public AuthController(TokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel model)
        {
            // Validate user credentials (this is just a simple example, use a proper validation mechanism)
            if (model.Username == "test" && model.Password == "password")
            {
                var token = _tokenService.GenerateToken(model.Username);
                return Ok(new { token });
            }

            return Unauthorized();
        }
    }
}