namespace Praticando_Encapsulamento_da_aula_anterior;

internal class Agenda
{
    private readonly List<Contato>  contatos;

    public Agenda(string proprietario)
    {
        Proprietario = proprietario;
    }

    public string Proprietario { get; }

    public int QuantidadeContatos => contatos.Count;



    public bool AdicionarContato(Contato contato)
    {
        if (contatos.Contains(contato))
        {
            Console.WriteLine($"Contato com esse nome ja esta na agenda.");
        }
        else 
        {
            contatos.Add(contato);
        }
    }


    public void ListarContatos()
    {
        foreach (var contato in contatos)
        {
            Console.WriteLine($"Contatos:");
            Console.WriteLine(contato);
        }
        Console.WriteLine($"Total de contatos: {QuantidadeContatos}");
    }
  
}
