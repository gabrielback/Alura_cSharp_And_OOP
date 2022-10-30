using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Utilitario
{
    public class GerenciadorDeBonificao
    {
        private double totalDeBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            totalDeBonificacao += funcionario.GetBonificacao();
        }
        public void Registrar(Diretor diretor)
        {
            totalDeBonificacao += diretor.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return totalDeBonificacao;
        }
    }
}
