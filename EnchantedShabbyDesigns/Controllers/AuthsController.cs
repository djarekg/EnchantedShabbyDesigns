using DotNetCore.AspNetCore;
using Esd.Models;
using Esd.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Esd.Controllers;

[ApiController]
[Route("auths")]
public sealed class AuthsController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthsController(IAuthService authService) => _authService = authService;

    [AllowAnonymous]
    [HttpPost]
    public IActionResult SignIn(SignInModel model) => _authService.SignInAsync(model).ApiResult();
}