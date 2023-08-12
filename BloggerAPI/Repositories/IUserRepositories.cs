using BloggerAPI.Models;

namespace BloggerAPI.Repositories
{
    public interface IUserRepositories
    {
        Task<Users?> GetUserByEmail(string email);
    }
}