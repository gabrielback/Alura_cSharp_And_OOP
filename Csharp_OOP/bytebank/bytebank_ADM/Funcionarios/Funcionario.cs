using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; private set; }
        public string Cpf { get;private set; }

        // Protected serve para acessar o atributo na classe base e nas classes herdeiras
        public double Salario { get;protected set; }

        public static int TotalDeFuncionarios { get;private set; }


        public Funcionario(string nome, string cpf, double salario)
        {
            Nome = nome;
            Cpf = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
            /*Console.WriteLine("Criando um funcionário.");*/

        }

        // Public virtual serve para reescrever o método nas classes herdeiras com a palavra reservada override
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }

        public virtual void AumentarSalario()
        {
            Salario *= 1.1;
        }
        public override string ToString()
        {
            return $@"
Nome: {Nome}
Cpf: {Cpf}
Salário: {Salario}
Bonificação: {(GetBonificacao() / Salario * 100).ToString("f2")}% = R${GetBonificacao()}
";
        }
    }
}
