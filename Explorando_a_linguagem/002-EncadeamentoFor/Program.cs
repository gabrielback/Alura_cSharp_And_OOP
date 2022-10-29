Console.WriteLine("Executando projeto 002 - Encadeando For");
// Saída do seguinte desenho:
//*
//**
//***
//****
//*****

for(int linha = 1; linha < 10; linha++)
{
    for(int colunas = 1; colunas < linha; colunas++)
    {
        Console.Write('*');
    }
    Console.WriteLine();
}

// Printar numeros multiplos de 3
int coeficiente = 4;
int inicio = 4;
int total = 104;
int numero = 0;

Console.WriteLine($"Múltiplos de: {coeficiente}. Iniciando em {inicio} até {total}");

for(numero = 1; numero <= total; numero++)
{
    if(numero % coeficiente == 0)
    {
        Console.WriteLine(numero);
    }
}
Console.WriteLine();
// Outra abordagem para printar números multiplos de 3
for(int i = 3; i < 100; i += 3)
{
    Console.WriteLine(i);
}

// Exercício
Console.WriteLine("Imprimir fatorial");

Console.WriteLine(Fatorial(6));

int Fatorial(int num)
{
    int sum = 1;
    for(int i = 1; i <= num; i++)
    {
        sum *= i;
    }
    return sum;
}