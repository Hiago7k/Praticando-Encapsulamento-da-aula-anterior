namespace Praticando_Encapsulamento_da_aula_anterior;

internal class Curso
{
    private  List<Estudante> matricula = new List<Estudante>();

    public Curso(string nome, int vagasTotais)
    {
        Nome = nome;
        VagasTotais = vagasTotais;
    }

    public string Nome { get;  }
    public int VagasTotais { get; }


    public bool Matricular(Estudante estudante)
    {
        if (matricula.Contains(vagasTotais))
        {
            // tem vaga
            return true;
        }
        else 
        {
            // sem vaga
            return false;
        }
    }
}
