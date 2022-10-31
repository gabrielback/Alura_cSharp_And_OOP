using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

#region
GerenciadorDeBonificao gerenciador = new GerenciadorDeBonificao();

Diretor diretor1 = new Diretor("Roberta Silva", "043.222.222-22", 5000);
Designer designer1 = new Designer("Rodrigo Coelho", "044.444.444-44",3000);
GerenteDeContas gerenteDeContas1 = new GerenteDeContas("Paulo Silveira", "044.333.333-33",4000);
Auxiliar auxiliar1 = new Auxiliar("Tiago Alves", "055.555.555-55",2000);


Console.WriteLine(diretor1);
Console.WriteLine(designer1);
Console.WriteLine(gerenteDeContas1); 
Console.WriteLine(auxiliar1);


gerenciador.Registrar(diretor1);
gerenciador.Registrar(designer1);
gerenciador.Registrar(gerenteDeContas1);
gerenciador.Registrar(auxiliar1);

Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());


Console.WriteLine();
Console.WriteLine("--------------------------");
Console.WriteLine("Antes do aumento.");
Console.WriteLine();

Console.WriteLine("Salário do Diretor: R$" + diretor1.Salario.ToString("f2"));
Console.WriteLine("Salário do Designer: R$" + designer1.Salario.ToString("f2"));
Console.WriteLine("Salário do Gerente de Contas: R$" + gerenteDeContas1.Salario.ToString("f2"));
Console.WriteLine("Salário do Auxiliar: R$" + auxiliar1.Salario.ToString("f2"));

Console.WriteLine();
Console.WriteLine("--------------------------");
Console.WriteLine();


diretor1.AumentarSalario();
designer1.AumentarSalario();
gerenteDeContas1.AumentarSalario();
auxiliar1.AumentarSalario();

Console.WriteLine();
Console.WriteLine("--------------------------");
Console.WriteLine("Salários após aumento.");
Console.WriteLine();

Console.WriteLine("Salário do Diretor: R$"+diretor1.Salario.ToString("f2"));
Console.WriteLine("Salário do Designer: R$" + designer1.Salario.ToString("f2"));
Console.WriteLine("Salário do Gerente de Contas: R$" + gerenteDeContas1.Salario.ToString("f2"));
Console.WriteLine("Salário do Auxiliar: R$" + auxiliar1.Salario.ToString("f2"));

Console.WriteLine();
Console.WriteLine("--------------------------");
Console.WriteLine();


Console.WriteLine("Total de funcionários: "+Funcionario.TotalDeFuncionarios);
#endregion

