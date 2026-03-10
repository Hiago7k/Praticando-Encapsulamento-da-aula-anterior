namespace Praticando_Encapsulamento_da_aula_anterior;

internal class Agenda
{
    private readonly List<Contato>  contatos;
    public string Proprietario { get; }



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
    }
  
}
