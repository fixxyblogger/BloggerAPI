using System;
using Agoda.IoC.Core;
using BloggerAPI.Models;
using BloggerAPI.Repositories;

namespace BloggerAPI.Services
{
    [RegisterPerRequest]
    public class AuthService : IAuthService
    {
        private readonly IUserRepositories _userRepositories;


        public AuthService(IUserRepositories userRepositories)
        {
            _userRepositories = userRepositories;
        }


        public async Task<Auth?> Login(AuthRequest request)
        {

            var users = await _userRepositories.GetUserByEmail(request.Email ?? string.Empty);
            if (users != null && users.Password == request.Password)
            {
                return new Auth() { UserInformation = users, Token = Guid.NewGuid().ToString() };
            }
            else
            {
                return null;
            }

        }


    }
}

