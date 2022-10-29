using bytebank.Titular;

namespace bytebank.Contas
{
    internal class ContaCorrente
    {
        // private set >> só pode ser alterada dentro da própria classe
        // para evitar que seja alterada fora da classe, atendendo assim
        // somente ao incremento de contas dentro da própria classe
        public static int TotalContasCriadas { get; private set; }
        public string Conta { get; set; }
        public string Agencia { get; set; }
        private double Saldo { get; set; }
        public Cliente Titular { get; set; }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (Saldo < valor)
            {
                return false;
            }
            if (Saldo < 0)
            {
                return false;
            }
            else
            {
                Saldo -= valor;
                contaDestino.Saldo += valor;
                return true;
            }
        }

        public void DefinirSaldo(double valor)
        {
            if(valor < 0)
            {
                return;
            }
            else
            {
                Saldo = valor;
            }
        }

        public override string ToString()
        {
            return @$"Titular da conta: {Titular.Nome}
Cód. Cliente: {Titular.CodCliente}
Cpf: {Titular.Cpf}
Profissão: {Titular.Profissao}
Conta:{Conta} 
Agencia: {Agencia}  
Saldo: {Saldo}
";
        }

        public ContaCorrente(Cliente titular, string conta, string agencia, double saldo)
        {
            Titular = titular;
            Conta = conta;
            Agencia = agencia;
            Saldo = saldo;
            TotalContasCriadas++;
        }
    }

}
