using bytebank_ADM.Funcionarios;

Funcionario funcionario1 = new Funcionario();
funcionario1.Nome = "Pedro";
funcionario1.Cpf = "063.293.944-44";
funcionario1.Salario = 1257;

Console.WriteLine(funcionario1.Salario);
Console.WriteLine(funcionario1.GetBonificacao());