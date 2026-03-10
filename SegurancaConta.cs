
namespace Praticando_Encapsulamento_da_aula_anterior;

internal class SegurancaConta
{
    public ContaBancaria MinhaConta;

    public void ValidarSaque(double valor)
    {
        if (valor > 1000)
        {
            Console.WriteLine("Saque negado pela politica de seguranca.");
        }
        else 
        {
            Console.WriteLine("Saque realizado com sucesso.");
        }
    }
}

