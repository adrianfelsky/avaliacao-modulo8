using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.interfaces
{
    public interface IRepositorioLivro
    {
        void Adicionar(Livros livro);

        Livros BuscarPorId(int id);

        IEnumerable<Livros> ListarTodos();

        IEnumerable<Livros> BuscarPorAutor(string autor);

        Task<IEnumerable<Livros>> ListarDisponiveisAsync();

        Task<string> BuscarDetalhesApiAsync(string titulo);
    }
}
