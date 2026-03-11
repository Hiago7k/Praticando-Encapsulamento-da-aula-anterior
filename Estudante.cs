namespace Praticando_Encapsulamento_da_aula_anterior;

internal class Estudante
{
    public string Nome { get;  }
    public int Nota1 { get; set; }
    public int Nota2 { get; set; }

    public decimal Media { get;  }
    // media de nota1 + nota2 / 2

    public string Situacao { get;  }
    // Aprovado nota maior ou igual a 6
    // Reprovado se nota menor que 6
}
