using Microsoft.AspNetCore.Mvc.ModelBinding;
using Tunify_Platform.Models.DTO;

namespace Tunify_Platform.Repositories.interfaces
{
    public interface IAccount
    {
        public Task<UserDto> Register(RegisterDto registerDto, ModelStateDictionary modelState);
        public Task<UserDto> Login(LoginDto loginDto);
        public Task Logout();

    }
}
