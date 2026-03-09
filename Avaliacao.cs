namespace Praticando_Encapsulamento_da_aula_anterior;

internal class Avaliacao
{
    public Avaliacao(string aluno)
    {
        Aluno = aluno;
    }

    public string Aluno { get;}
    public double Nota { get; private set; }

    private double notaNova;

    public void AtribuirNota(double nota)
    {
        if (Nota >= 10 && Nota <= 0)
        {
            nota = notaNova;
            Console.WriteLine($"Nota Atribuida {notaNova}");
        }
        else 
        {
            Console.WriteLine($"Erro: a nota deve estar entr 0 e 10");
        }
    }
}
