using GerenciadorDeTarefas.Communication.Requests;
using GerenciadorDeTarefas.Communication.Responses;

namespace GerenciadorDeTarefas.Application.UseCases.Tarefa.CriarTarefa;

public class CriarTarefaUseCase
{
    public ResponseCriarTarefa Execute(RequestTarefa request)
    {
        return new ResponseCriarTarefa
        {
            Id = 2,
            Nome = request.Nome,
            Descricao = request.Descricao,
            Prioridade = request.Prioridade,
            Status = request.Status,
            DataLimite = request.DataLimite,
        };
    }
}
