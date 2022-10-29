using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystem
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }
        public float Altura { get; set; }


        public override string ToString()
        {
            return $"\nNome: {Nome}\nIdade: {Idade}\nAltura: {Altura}m\nPeso: {Peso}kg";
        }

    }
}
