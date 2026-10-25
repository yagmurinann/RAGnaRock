using Microsoft.AspNetCore.Mvc;

namespace RAGnaRock.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RagSearchController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "RAGSearchAPI";
    }
}
