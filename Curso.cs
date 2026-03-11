namespace Praticando_Encapsulamento_da_aula_anterior;

internal class Curso
{
    private  List<Estudante> matricula = new List<Estudante>();


    public string Nome { get;  }
    public int VagasTotais { get; }


    public bool Matricular(Estudante estudante)
    {
        if (matricula.Contains(VagasTotais))
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
