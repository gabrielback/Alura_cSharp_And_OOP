using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_002_Livro
{
    public class Livro
    {
        public int AnoPublicacao { get; set; }
        public string Autor { get; set; }
        public int EstiloLiterario { get; set; }
        public string Isbn { get;private set; }
        public string NumeroDePaginas { get; set; }
        public string PaisPublicacao { get; set; }
        public string Titulo { get;private set; }

        public Livro(string isbn, string titulo)
        {
            Isbn = isbn;
            Titulo = titulo;
        }
    }
}
