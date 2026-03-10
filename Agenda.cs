namespace Praticando_Encapsulamento_da_aula_anterior;

internal class Agenda
{
    private readonly List<Contato>  contatos;

    public Agenda(string proprietario)
    {
        Proprietario = proprietario;
        contatos = new List<Contato>();
    }

    public string Proprietario { get; }

    public int QuantidadeContatos => contatos.Count;


    public bool AdicionarContato(Contato contato)
    {
        if (contatos.Any(c => c.Nome == contato.Nome))
        {
            Console.WriteLine("erro usuario ja esta na lista");
            return false;
        }

        contatos.Add(contato);
         return true;
        
    }

    public void ListarContatos()
    {
        foreach (var item in contatos)
        {
            Console.WriteLine($"{item.Nome} | {item.Telefone}");
        }
        Console.WriteLine($"Total de contatos: {QuantidadeContatos}");
    }

}
