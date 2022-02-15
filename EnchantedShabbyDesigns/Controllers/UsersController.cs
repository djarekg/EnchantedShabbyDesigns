using Esd.Models;
using Esd.Services;
using Microsoft.AspNetCore.Mvc;

namespace Esd.Controllers;

[ApiController]
[Route("users")]
public sealed class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService) => _userService = userService;

    [HttpPost]
    public IActionResult Add(UserModel model) => Ok(_userService.AddAsync(model));

    [HttpDelete("{id}")]
    public IActionResult Delete(long id) => Ok(_userService.DeleteAsync(id));

    [HttpGet("{id}")]
    public IActionResult Get(long id) => Ok(_userService.GetAsync(id));

    [HttpPatch("{id}/inactivate")]
    public IActionResult Inactivate(long id) => Ok(_userService.InactivateAsync(id));

    [HttpGet]
    public IActionResult List() => Ok(_userService.ListAsync());

    [HttpPut("{id}")]
    public IActionResult Update(UserModel model) => Ok(_userService.UpdateAsync(model));
}
