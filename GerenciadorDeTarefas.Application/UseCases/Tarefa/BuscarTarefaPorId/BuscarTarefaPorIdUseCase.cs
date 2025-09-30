using GerenciadorDeTarefas.Communication.Responses;

namespace GerenciadorDeTarefas.Application.UseCases.Tarefa.BuscarTarefaPorId;

public class BuscarTarefaPorIdUseCase
{
    public ResponseTarefaCompleta Execute(int id)
    {
        return new ResponseTarefaCompleta
        {
            Id = id,
            Nome = "Limpar o quarto",
            Descricao = "Preciso aspirar, passar pano, e arrumar a bagunça.",
            Prioridade = Communication.Enums.PrioridadeType.media,
            Status = Communication.Enums.StatusType.aguardando,
            DataLimite = new DateTime(year: 2026, month: 09, day: 28)
        };
    }
}
