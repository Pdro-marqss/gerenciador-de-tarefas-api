using GerenciadorDeTarefas.Application.UseCases.Tarefa.BuscarTodos;
using GerenciadorDeTarefas.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeTarefas.API.Controllers;

public class TarefaController : GerenciadorDeTarefasBaseController
{
    [HttpGet]
    [ProducesResponseType(typeof(ResponseTodasAsTarefas),StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult BuscarTodasAsTarefas()
    {
        var buscarTodasAsTarefasUseCase = new BuscarTodasAsTarefasUseCase();
        var response = buscarTodasAsTarefasUseCase.Execute();

        if(response.Tarefas.Any())
        {
            return Ok(response);
        }

        return NoContent();
    }
}
