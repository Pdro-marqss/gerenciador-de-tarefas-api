using GerenciadorDeTarefas.Application.UseCases.Tarefa.BuscarTarefaPorId;
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


    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTarefaCompleta), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult BuscarTarefaPorId(int id)
    {
        var buscarTarefaPorIdUserCase = new BuscarTarefaPorIdUseCase();
        var response = buscarTarefaPorIdUserCase.Execute(id);

        return Ok(response);
    }
}
