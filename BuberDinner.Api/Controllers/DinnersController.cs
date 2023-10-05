using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers;

[Route("[controller]")]
public class DInnersController: ApiController
{
    [HttpGet]
    public IActionResult ListDinners()
    {
        return Ok(Array.Empty<string>());
    }
}