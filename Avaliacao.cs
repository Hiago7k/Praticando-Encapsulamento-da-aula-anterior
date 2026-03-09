namespace Praticando_Encapsulamento_da_aula_anterior;

internal class Avaliacao
{
    public Avaliacao(string aluno)
    {
        Aluno = aluno;
    }

    public string Aluno { get;}
    public double Nota { get; private set; }


    public void AtribuirNota(double nota)
    {
        if (nota >= 0 && nota <= 10)
        {
            Nota = nota;
            Console.WriteLine($"Aluno: {Aluno}");
            Console.WriteLine($"Nota atribuida: {nota}");
        }
        else 
        {
            Console.WriteLine($"Erro: A nota deve estar entre 0 e 10");
        }
    }
}
