namespace bytebank.Titular
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

        private string _codCliente;
        public string CodCliente
        {
            get 
            {
                return _codCliente; 
            }
            private set 
            {
                if(value.Length == 9)
                _codCliente = value; 
            }
        }

        public Cliente()
        {
        }

        public Cliente(string nome, string cpf, string profissao, string codCliente)
        {
            Nome = nome;
            Cpf = cpf;
            Profissao = profissao;
            CodCliente = codCliente;
        }
    }
}
