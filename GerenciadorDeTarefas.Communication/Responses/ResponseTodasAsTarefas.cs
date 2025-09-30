namespace GerenciadorDeTarefas.Communication.Responses;

public class ResponseTodasAsTarefas
{
    public List<ResponseTarefaSimplificada> Tarefas { get; set; } = new List<ResponseTarefaSimplificada>();
}
