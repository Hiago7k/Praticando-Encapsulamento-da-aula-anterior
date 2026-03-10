namespace Praticando_Encapsulamento_da_aula_anterior;

internal class Agenda
{
    private readonly List<Contato>  contatos = new List<Contato>();

    public Agenda(string proprietario)
    {
        Proprietario = proprietario;
    }

    public string Proprietario { get; }

    public int QuantidadeContatos => contatos.Count;



    public bool AdicionarContato(Contato contato)
    {

        if (!contatos.Contains(contato))
        {
            contatos.Add(contato);
            return true;

        }
        else
        {
            Console.WriteLine("erro usuario ja esta na lista");
            return false;
        }
    }


    public void ListarContatos()
    {
        foreach (var item in contatos)
        {
            Console.WriteLine(item);
        }
      //  Console.WriteLine($"Total de contatos: {QuantidadeContatos}");
    }
  
}
