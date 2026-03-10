namespace Praticando_Encapsulamento_da_aula_anterior;

internal class ContaBancaria
{
   private double saldo;
    public ContaBancaria(string titular, double saldo)
    {
        Titular = titular;
        Saldo = saldo;
    }


    public double Saldo { get; }

    public string Titular { get;}

    public void Sacar(double valor)
    {
        SegurancaConta validador = new SegurancaConta();
        validador.ValidarSaque(Saldo);
        var saldo = Saldo - valor;
        //Console.WriteLine($"Seu saldo atual e de: R$ {saldo}");

    }

}
