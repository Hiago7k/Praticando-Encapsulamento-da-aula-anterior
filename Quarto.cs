namespace Praticando_Encapsulamento_da_aula_anterior;

internal class Quarto
{
    public Quarto(int numero)
    {
        Numero = numero;
    }

    public int Numero { get; set; }
    public double ValorDiaria 
    {
        get { return ValorDiaria }
        set 
        {
            if (ValorDiaria <= 0)
                Console.WriteLine($"O valor deve ser positivo");
        }
    }

}
