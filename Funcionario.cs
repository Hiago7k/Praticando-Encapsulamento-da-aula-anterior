
namespace Praticando_Encapsulamento_da_aula_anterior;

internal class Funcionario
{
    private double salario;

    public Funcionario(string nome, double salario)
    {
        Nome = nome;
        this.salario = salario;
    }

    public string Nome { get;}

    public double Salario { get; }

    public void ReajustarSalario(double novoValor)
    {
        if (novoValor > salario)
        {
            salario += novoValor;
            Console.WriteLine($"Funcinario: {Nome}");
            Console.WriteLine($"Salario Atual: R$ {novoValor}");
        }
        else
        {
            Console.WriteLine("Erro: o novo salario deve ser maior que o atual");
        }
    }
}
