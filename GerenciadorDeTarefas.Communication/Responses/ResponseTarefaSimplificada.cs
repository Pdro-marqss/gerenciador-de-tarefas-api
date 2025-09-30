namespace GerenciadorDeTarefas.Communication.Responses;

public class ResponseTarefaSimplificada
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
}
