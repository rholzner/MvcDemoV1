using Microsoft.AspNetCore.Mvc;

namespace _6.ShowRouting.Controllers;

[Route("v1")]
public class MyApiController : Controller
{
    [HttpGet("myapi")]
    [HttpHead("myhead")]
    public IActionResult Index([FromQuery] string? q)
    {
        if (q?.StartsWith("r") ?? false)
        {
            return BadRequest("no r pls");
        }
        return Ok("Hello World");
    }

    [HttpPost("edit")]
    public IActionResult Edit([FromBody] string data)
    {
        return Ok($"Hello World -- {data}");
    }
}
