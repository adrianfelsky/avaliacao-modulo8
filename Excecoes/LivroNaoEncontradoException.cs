using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Excecoes
{
    public class ProdutoNaoEncontradoException : Exception
    {
        public ProdutoNaoEncontradoException(int id, string titulo)
            : base($"Livrp #{id} - \"{titulo}\" não encontrado.") { }

    }
}
