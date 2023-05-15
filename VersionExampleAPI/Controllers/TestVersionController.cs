using Microsoft.AspNetCore.Mvc;

namespace VersionExampleAPI.Controllers;

[ApiController]
[ApiVersion("1")]
[ApiVersion("2")]
[Route("api/v{version:apiVersion}/[controller]")]
public class VersioningTestController : Controller
{
    [HttpGet]
    [MapToApiVersion("1")]
    [Route("api/VersioningTest/get")]
    public IActionResult Get()
    {
        return Ok("V1");
    }

    [HttpGet]
    [MapToApiVersion("2")]
    [Route("api/VersioningTest/get")]
    public IActionResult GetV2()
    {
        return Ok("V2");
    }
}



