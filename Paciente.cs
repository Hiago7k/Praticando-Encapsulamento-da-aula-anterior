
namespace Praticando_Encapsulamento_da_aula_anterior;

public class Paciente
{
    public Paciente(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public string Nome { get; }
    public int Idade { get; }
}
