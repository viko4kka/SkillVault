using Microsoft.AspNetCore.Mvc;

namespace SkillVault.Modules.Users;

[ApiController]
[Route("users")]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    //di uzyte
    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_userService.GetAll());
    }

    [HttpPost]
    public IActionResult Add(User user)
    {
        _userService.Add(user);
        return Ok(user);
    }
}