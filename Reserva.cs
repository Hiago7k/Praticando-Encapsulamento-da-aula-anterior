namespace Praticando_Encapsulamento_da_aula_anterior;

internal class Reserva
{
    private int diarias;

    public Reserva(Hospede hospede, Quarto quarto, Quarto valorDiaria)
    {
        this.hospede = hospede;
        this.quarto = quarto;
        ValorDiaria = valorDiaria;
    }

    public Hospede hospede { get;}
    public Quarto quarto { get;}
    public Quarto ValorDiaria { get;}

}
