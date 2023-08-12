using System;
using Agoda.IoC.Core;
using BloggerAPI;
using BloggerAPI.Models;

namespace BloggerAPI.Repositories
{
    [RegisterPerRequest]
    public class UserRepositories : IUserRepositories
    {

        private static List<Users> users = new List<Users>() { new Users() { ID = 1, Email = "fixxy", Password = "123456" } };

        public UserRepositories()
        {
        }

        public Task<Users?> GetUserByEmail(string email)
        {
            return Task.Run(() => users.FirstOrDefault(x => x.Email == email));
        }


    }
}

