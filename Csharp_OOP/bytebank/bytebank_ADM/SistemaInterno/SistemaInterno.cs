using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel usuario, string login, string senha)
        {
            bool usuarioLogado = usuario.Autenticar(login, senha);
            if (usuarioLogado)
            {
                Console.WriteLine("Boas Vindas ao Nosso Sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Login ou senha incorretos!");
                return false;
            }
        }
    }
}
