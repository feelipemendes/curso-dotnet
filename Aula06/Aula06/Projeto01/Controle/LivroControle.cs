using Projeto01.Contratos;
using Projeto01.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Controle
{
    public class LivroControle : ILivrosControle
    {
        public void ExportarParaTxt(Livro livro)
        {
            using (StreamWriter streamWriter
            = new StreamWriter("c:\\temp\\livros.txt", true))
            {
                streamWriter.WriteLine("Id do Livro....: " + livro.IdLivro);
                streamWriter.WriteLine("Título.........: " + livro.Titulo);
                streamWriter.WriteLine("Resumo.........: " + livro.Resumo);
                streamWriter.WriteLine("Autor..........: " + livro.Autor.Nome);
                streamWriter.WriteLine("---");
            }
        }
    }
}
