using GerenciadorDeTarefas.Communication.Enums;

namespace GerenciadorDeTarefas.Communication.Responses;

public class ResponseCriarTarefa
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public PrioridadeType Prioridade { get; set; }
    public DateTime DataLimite { get; set; }
    public StatusType Status { get; set; }
}
