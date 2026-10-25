using Microsoft.AspNetCore.Mvc;

namespace RAGnaRock.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "OrdersAPI";
    }
}
