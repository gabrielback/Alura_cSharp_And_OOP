using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

Funcionario funcionario1 = new Funcionario("Pedro Salazares", "063.293.944-44", 2650);

Diretor diretor = new Diretor("Roberta Silva", "043.384.684-33", 5000);

Console.WriteLine(funcionario1); 

Console.WriteLine(diretor);

GerenciadorDeBonificao gerenciador = new GerenciadorDeBonificao();
gerenciador.Registrar(funcionario1);
gerenciador.Registrar(diretor);

Console.WriteLine("Total de bonificações: "+gerenciador.GetTotalBonificacao());