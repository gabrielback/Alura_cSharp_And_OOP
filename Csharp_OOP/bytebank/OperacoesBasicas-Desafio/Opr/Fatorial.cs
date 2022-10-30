using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesBasicas_Desafio.Opr
{
    public class Fatorial
    {
        public double Calcular(double number)
        {
            var fact = number;
            for(int i = 1; i < fact; i++)
            {
                number *= i;
            }
            return number;
        }
    }
}
