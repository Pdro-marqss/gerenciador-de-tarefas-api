using GerenciadorDeTarefas.Communication.Responses;

namespace GerenciadorDeTarefas.Application.UseCases.Tarefa.BuscarTodos;

public class BuscarTodasAsTarefasUseCase
{
    public ResponseTodasAsTarefas Execute()
    {
        return new ResponseTodasAsTarefas
        {
            Tarefas = new List<ResponseTarefaSimplificada>
            {
                new ResponseTarefaSimplificada
                {
                    Id = 1,
                    Nome = "Estudar",
                    Descricao = "Estudar Backend com C# e .NET quando chegar em casa."
                }
            }
        };
    }
}
