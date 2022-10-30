using OperacoesBasicas_Desafio;

Console.WriteLine("Olá, Bem vindo ao Basic Calculator!");
Operacoes operacoes = new Operacoes();

Console.WriteLine("O valor da soma é: "+operacoes.Soma.Calcular(1,1));
Console.WriteLine("O valor da subtração é: "+operacoes.Subtracao.Calcular(1,1));
Console.WriteLine("O valor da divisão é: "+operacoes.Divisao.Calcular(10,2));
Console.WriteLine("O valor da Multiplicação é: "+operacoes.Multiplicacao.Calcular(2,2));
Console.WriteLine("O valor Fatorial é: "+operacoes.Fatorial.Calcular(4));

Console.ReadKey();