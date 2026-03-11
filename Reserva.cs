namespace Praticando_Encapsulamento_da_aula_anterior;

internal class Reserva
{
    private int diarias;

    public Reserva(Hospede hospede, Quarto quarto, int diarias)
    {
        this.hospede = hospede;
        this.quarto = quarto;
        this.diarias = diarias;
    }

    public Hospede hospede { get; }
    public Quarto quarto { get; }
    

}

