namespace Praticando_Encapsulamento_da_aula_anterior;

internal class Veiculo
{
    private double velocidadeAtual;

    public Veiculo(string placa)
    {
        Placa = placa;
    }

    public string Placa { get; set; }
    public decimal VelocidadeAtual { get;}


    public void AtualizarVelocidade(double novaVelocidade)
    {
        velocidadeAtual = novaVelocidade;
        Console.WriteLine($"Velocidade atual {novaVelocidade}");
    }
}
