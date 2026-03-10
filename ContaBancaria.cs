namespace Praticando_Encapsulamento_da_aula_anterior;

internal class ContaBancaria
{
    private double Saldo;

    public ContaBancaria(double saldo, string titular)
    {
        Saldo = saldo;
        Titular = titular;
    }

    public double Saldo { get; }

    public string Titular { get;}

    public void Sacar(double valor)
    {
        
    }
}
