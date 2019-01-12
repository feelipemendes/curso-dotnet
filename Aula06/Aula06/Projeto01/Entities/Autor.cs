using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entities
{
    public class Autor
    {
        public int IdAutor { get; set; }
        public string Nome { get; set; }

        public List<Livro> Livros { get; set; }

        public Autor()
        {
            //vazio
        }

        public Autor(int idAutor, string nome)
        {
            IdAutor = idAutor;
            Nome = nome;
        }
    }
}
