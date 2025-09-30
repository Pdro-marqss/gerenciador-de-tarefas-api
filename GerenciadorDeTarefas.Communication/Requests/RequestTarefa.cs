using GerenciadorDeTarefas.Communication.Enums;

namespace GerenciadorDeTarefas.Communication.Requests;

public class RequestTarefa
{
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public PrioridadeType Prioridade { get; set; }
    public DateTime DataLimite { get; set; }
    public StatusType Status { get; set; }
}
