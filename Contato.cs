
namespace Praticando_Encapsulamento_da_aula_anterior;

internal class Contato
{
    public Contato(string nome, string telefone)
    {
        Nome = nome;
        Telefone = telefone;
    }

    public string Nome { get; }
    public string Telefone { get; }
}
