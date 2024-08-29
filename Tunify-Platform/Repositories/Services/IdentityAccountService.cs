using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Tunify_Platform.Models.DTO;
using Tunify_Platform.Repositories.interfaces;

namespace Tunify_Platform.Repositories.Services
{
    public class IdentityAccountService : IAccount
    {
        private UserManager<IdentityUser> _userManager;
        private SignInManager<IdentityUser> _signInManager;
        public IdentityAccountService(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public async Task<UserDto> Register(RegisterDto registerDto, ModelStateDictionary modelState)
        {
            var user = new IdentityUser
            {
                UserName = registerDto.Username,
                Email = registerDto.Email
            };
            var result= await _userManager.CreateAsync(user, registerDto.Password);
            if (result.Succeeded)
            {
                return new UserDto
                {
                    Id = user.Id,
                    Username = user.Id
                };
            }
            foreach (var error in result.Errors)
            {
                var errorCode = error.Code.Contains("Password") ? nameof(registerDto) :
                                error.Code.Contains("Email") ? nameof(registerDto) :
                                error.Code.Contains("Username") ? nameof(registerDto) : "";

                modelState.AddModelError(errorCode, error.Description);
            }

            return null;

        }
        public async Task<UserDto> Login(LoginDto loginDto)
        {
            var user = await _userManager.FindByNameAsync(loginDto.Username);
            if(user != null)
            {
                bool passValidation = await _userManager.CheckPasswordAsync(user, loginDto.Password);
                if(passValidation)
                {
                    return new UserDto
                    {
                        Id = user.Id,
                        Username = user.Id
                    };
                }
            }
            return null;
        }

        public async Task Logout()
        {
            await _signInManager.SignOutAsync();
        }

       
    }
}
