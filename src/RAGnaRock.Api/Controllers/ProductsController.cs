using Microsoft.AspNetCore.Mvc;

namespace RAGnaRock.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "ProductsAPI";
    }
}
