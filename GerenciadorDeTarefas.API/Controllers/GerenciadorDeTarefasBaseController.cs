using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeTarefas.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public abstract class GerenciadorDeTarefasBaseController : ControllerBase
{
    [HttpGet("api-status")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult StatusDaApi()
    {
        return Ok("API Funcionando ...");
    }
}
