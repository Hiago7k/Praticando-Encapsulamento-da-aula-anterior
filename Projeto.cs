namespace Praticando_Encapsulamento_da_aula_anterior;

internal class Projeto
{
    private List<string> tarefas = new();
    public string Nome { get; set; }


    public void AdicionarTarefa(string tarefa)
    {
        tarefas.Add(tarefa);
    }

    public void ExibirTarefas()
    {
        foreach (var tarefa in tarefas)
        {
            Console.WriteLine($"Total: {tarefa}");
        }
    }
}
