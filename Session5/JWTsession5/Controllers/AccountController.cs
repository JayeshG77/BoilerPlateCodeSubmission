using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session5.DTOs;
using Session5.Repository;

namespace Session5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        readonly IAuthManager _authManager;
        public AccountController(IAuthManager authManager)
        {
                _authManager = authManager;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(UserDto user)
        {
            var errors =await _authManager.RegisterUserAsync(user);
            if(errors.Any())
            {
                foreach (var error in errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
                return BadRequest();
            }
            return Ok();
        }

        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult> Login(LoginDto loginDTo)
        {
            var authResp = await _authManager.Login(loginDTo);
            if (authResp == null)
            {
                return Unauthorized();
            }
            else
            {
                return Ok(authResp);
            }
        }
    }
}
