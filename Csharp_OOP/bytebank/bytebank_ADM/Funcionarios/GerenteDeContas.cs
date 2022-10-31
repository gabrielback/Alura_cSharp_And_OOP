using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas:Funcionario
    {
        public GerenteDeContas(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {

        }
        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }
    }
}
