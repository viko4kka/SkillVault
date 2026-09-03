using Microsoft.AspNetCore.Mvc;

namespace SkillVault.Modules.Users;

[ApiController]
[Route("hello")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public IActionResult SayHello()
    {
        return Ok("Hello");
    }
}