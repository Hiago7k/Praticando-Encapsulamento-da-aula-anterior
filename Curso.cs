//using System.Linq;

//namespace Praticando_Encapsulamento_da_aula_anterior;

//internal class Curso
//{
//    private  List<Estudante> matricula = new List<Estudante>();

//    public Curso(string nome, int vagasTotais)
//    {
//        Nome = nome;
//        VagasTotais = vagasTotais;
//    }

//    public string Nome { get;  }
//    public int VagasTotais { get; set; }
  


//    public bool Matricular(Estudante estudante)
//    {
//        if (matricula.Any(estudante = VagasTotais > estudante))
//        {
//            Console.WriteLine($"Estudante matriculado com sucesso");
//            return true;
//        }
//        else 
//        {
//            Console.WriteLine($"Erro: nao ha vagas disponiveis para esse curso");
//            return false;
//        }
//    }
//}
