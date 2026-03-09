namespace Praticando_Encapsulamento_da_aula_anterior;

internal class Projeto
{
    private List<string> tarefas = new();

    public Projeto(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; set; }
    public int QuantidadeTarefas => tarefas.Count;
 


    public void AdicionarTarefa(string tarefa)
    {
        tarefas.Add(tarefa);
    }

    public void ExibirTarefas()
    {
        Console.WriteLine($"Projeto: {Nome}");
        Console.WriteLine($"Tarefas: ");

        foreach (var tarefa in tarefas)
        {
            
            Console.WriteLine($"- {tarefa}");
        }
        Console.WriteLine($"Total: {QuantidadeTarefas}");
    }
}
