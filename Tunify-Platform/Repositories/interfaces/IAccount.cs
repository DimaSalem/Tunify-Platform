﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Security.Claims;
using Tunify_Platform.Models.DTO;

namespace Tunify_Platform.Repositories.interfaces
{
    public interface IAccount
    {
        public Task<UserDto> Register(RegisterDto registerDto, ModelStateDictionary modelState);
        public Task<UserDto> Login(LoginDto loginDto);
        public Task Logout();
        public Task<string> GenerateToken(IdentityUser user, TimeSpan expiryDate);

        //for test 
        public Task<UserDto> userProfile(ClaimsPrincipal claimsPrincipal);
    }
}
