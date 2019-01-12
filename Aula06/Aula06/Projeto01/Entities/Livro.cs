using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entities
{
    public class Livro
    {
        public int IdLivro { get; set; }
        public string Titulo { get; set; }
        public string Resumo { get; set; }
        public Autor Autor { get; set; }

        public Livro()
        {
            //vazio
        }

        public Livro(int idLivro, string titulo, string resumo)
        {
            IdLivro = idLivro;
            Titulo = titulo;
            Resumo = resumo;
        }
    }
}
