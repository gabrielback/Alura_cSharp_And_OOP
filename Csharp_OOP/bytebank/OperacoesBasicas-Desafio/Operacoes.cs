using OperacoesBasicas_Desafio.Basicas;
using OperacoesBasicas_Desafio.Opr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesBasicas_Desafio
{
    internal class Operacoes
    {
        public Soma Soma { get; private set; }
        public Subtracao Subtracao { get; private set; }
        public Divisao Divisao { get; private set; }
        public Multiplicacao Multiplicacao { get; private set; }
        public Fatorial Fatorial { get; private set; }

        public Operacoes()
        {
            Soma = new Soma();
            Subtracao = new Subtracao();
            Divisao = new Divisao();
            Multiplicacao = new Multiplicacao();
            Fatorial = new Fatorial();
        }

    }
}
