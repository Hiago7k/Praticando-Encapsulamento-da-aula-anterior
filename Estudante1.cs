namespace Praticando_Encapsulamento_da_aula_anterior;

internal class Estudante1
{
    public Estudante1(string nome)
    {
        Nome = nome;
    }

    public string Nome { get;  }
    public double Nota1 { get;  set; }
    public double Nota2 { get;  set; }

    public double Media => (Nota1 + Nota2) /2;
   

    public string Situacao
    {
        get 
        {
            if (Media >= 6)
            {
                return "Aprovado";
            }
            else 
            {
                return "Reprovado";
            }

        }
    }
}
