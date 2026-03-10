using Praticando_Encapsulamento_da_aula_anterior;


// Atividade 1
//Veiculo veiculo = new Veiculo("ABC-1234");

//Console.WriteLine($"Veiculo {veiculo.Placa}");
//veiculo.AtualizarVelocidade(72.5);

// Atividade 2
//Avaliacao avaliacao = new Avaliacao("Carla Silva");
//avaliacao.AtribuirNota(11); // invalida

//avaliacao.AtribuirNota(7.5); // valida

// Atividade 3

//Paciente paciente = new Paciente("Luiz Costa", 42);
//HistoricoMedico historico = new HistoricoMedico("XPT-9987");
//historico.ExibirCodigo();

// Atividade 4
//Funcionario f = new Funcionario("Fernanda Lima", 4000);
//f.ReajustarSalario(3500); // invalidado
//f.ReajustarSalario(5500); // Valido

// Atividade 5

//Projeto projeto = new Projeto("Sistema de inventario");
//projeto.AdicionarTarefa("Criar tela de login");
//projeto.AdicionarTarefa("Implementar banco de dados");
//projeto.ExibirTarefas();


// Atividade 6
//ContaBancaria conta = new ContaBancaria("Carlos Silva", 2500);
//conta.Sacar(1500);
//Console.WriteLine();
//conta.Sacar(800);

// Atividade 7
Agenda agenda = new Agenda("Marina Souza");
agenda.AdicionarContato(new Contato("Carlos", "11998887777"));
agenda.AdicionarContato(new Contato("Carlos", "11998887777")); // duplicado
agenda.AdicionarContato(new Contato("Julia", "21988776655"));
agenda.ListarContatos();


