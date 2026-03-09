namespace Praticando_Encapsulamento_da_aula_anterior;

internal class HistoricoMedico
{
    public string CodigoProntuario { get; }


    public void ExibirCodigo()
    {
        Console.WriteLine($"Codigo do Pontuario" {CodigoProntuario});
    }
}
