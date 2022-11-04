using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            #region
            /*ContaCorrente conta1 = new ContaCorrente(7480, 874250);
            Console.WriteLine(ContaCorrente.TaxaOperacao);

            ContaCorrente conta2 = new ContaCorrente(7480, 874250);
            Console.WriteLine(ContaCorrente.TaxaOperacao);

            ContaCorrente conta3 = new ContaCorrente(7480, 874250);
            Console.WriteLine(ContaCorrente.TaxaOperacao);

            Console.ReadLine();*/
            #endregion

            try
            {
                Metodo();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Ocorreu um erro! Não é possível dividir um numero por 0! Mensagem: " + e.Message);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Aconteceu um erro!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Aconteceu um erro! " + e.Message);
            }
            Console.ReadKey();
        }
        public static void Metodo()
        {
            TestaDivisao(0);
        }
        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);

            Console.WriteLine("O resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch
            {
                Console.WriteLine("Exceção com número = " + numero + " e divisor = " + divisor);
                throw;
            }
        }
    }
}
