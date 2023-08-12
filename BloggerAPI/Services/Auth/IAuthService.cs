using BloggerAPI.Models;

namespace BloggerAPI.Services
{
    public interface IAuthService
    {
        Task<Auth?> Login(AuthRequest request);
    }
}