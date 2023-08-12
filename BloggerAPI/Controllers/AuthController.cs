using BloggerAPI.Models;
using BloggerAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BloggerAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{

    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [AllowAnonymous]
    [HttpPost(Name = "Login")]
    public async Task<IActionResult> Login(AuthRequest request)
    {
        return Ok(await _authService.Login(request));
    }
}

