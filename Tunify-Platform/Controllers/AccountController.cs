using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.Identity.Client;
using Tunify_Platform.Models.DTO;
using Tunify_Platform.Repositories.interfaces;
namespace Tunify_Platform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccount _userService;
        public AccountController(IAccount context)
        {
            _userService = context;
        }


        [HttpPost("Register")] //Register
        public async  Task<ActionResult<UserDto>> Register(RegisterDto registerDto)
        {
            var user = await _userService.Register(registerDto, this.ModelState);
                if (ModelState.IsValid) return user;
                if(user == null) return Unauthorized();

            return BadRequest();
        }

        [HttpPost("Login")] //Login
        public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
        {
            var user = await _userService.Login(loginDto);
            if (user == null) return Unauthorized();
            return Ok(user);
        }

        
        [HttpPost("Logout")] //Logout
        public async Task<IActionResult> Logout()
        {
            await _userService.Logout();
            return Ok();
        }


        //for test 
        //[Authorize(AuthenticationSchemes = "Bearer")]
        //[Authorize(Roles = "Admin")]
        [Authorize(Policy = "CanEdit")]
        [HttpGet("Profile")]
        public async Task<ActionResult<UserDto>> Profile()
        {
            return await _userService.userProfile(User);
        }

        //for test 
        //[Authorize(AuthenticationSchemes = "Bearer")]
        //[Authorize]
        //[Authorize(Roles = "Admin")]
        [Authorize(Policy = "AdminOnly")]
        [HttpGet("Tokens")]
        //[Route("Tokens")]
        public IActionResult TestAuthorization()
        {
            return Ok("You're Authorized");
        }
    }
}
