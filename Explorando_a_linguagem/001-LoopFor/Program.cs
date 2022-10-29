Console.WriteLine("Executando projeto 001 - Investimento a Longo Prazo");

double rendimentoAoMes = 1.005;
double investimento = 0;
double investimentoMensal = 1000;
int anos = 30;
for (int ano = 1; ano <= anos; ano++)
{
    for(int mes = 1; mes <= 12; mes++)
    {
        investimento *= rendimentoAoMes;
        investimento += investimentoMensal;
    }
    rendimentoAoMes += 0.001;
}

Console.WriteLine($"Depois de {anos} anos, você terá um total de: " + investimento);