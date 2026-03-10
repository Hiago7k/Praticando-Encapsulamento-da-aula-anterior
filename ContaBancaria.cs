namespace Praticando_Encapsulamento_da_aula_anterior;

internal class ContaBancaria
{
    private decimal Saldo;

    public ContaBancaria(decimal saldo, string titular)
    {
        Saldo = saldo;
        Titular = titular;
    }

    public string Titular { get;}
}
