using Projeto01.Controle;
using Projeto01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarando autor..
            Autor autor1 = new Autor();
            autor1.Livros = new List<Livro>();
            autor1.IdAutor = 1;
            autor1.Nome = "Tolkien";

            //declarando livros..
            Livro livro1 = new Livro();
            livro1.Autor = autor1;
            livro1.IdLivro = 1;
            livro1.Titulo = "Senhor dos Aneis";
            livro1.Resumo = "Livro da trilogia Senhor dos Anéis";

            Livro livro2 = new Livro(2, "O Hobbit", "Livro da Saga do Hobbit");
            livro2.Autor = autor1;
            //relacionando o autor aos livros..
            autor1.Livros.Add(livro1); //adicionando..
            autor1.Livros.Add(livro2); //adicionando..
                                       //imprimindo..
            Console.WriteLine("\nDados do Autor:");
            Console.WriteLine("\tId.....: " + autor1.IdAutor);
            Console.WriteLine("\tNome...: " + autor1.Nome);
            foreach (Livro livro in autor1.Livros)
            {
                Console.WriteLine("\nDados do Livro:");
                Console.WriteLine("\tId.....: " + livro.IdLivro);
                Console.WriteLine("\tTitulo.: " + livro.Titulo);
                Console.WriteLine("\tResumo.: " + livro.Resumo);
                Console.WriteLine("\tAutor..: " + livro.Autor.Nome);
            }

            try
            {
                AutorControle autorControle = new AutorControle();
                autorControle.ExportarParaCsv(autor1);
                Console.WriteLine("\nDados do Autor gravadosem CSV com sucesso.");
}
            catch (Exception e)
            {
                //imprimir mensagem de erro..
                Console.WriteLine("Erro ao exportar Autor: " + e.Message);
            }
            try
            {
                LivroControle livroControle = new LivroControle();
                livroControle.ExportarParaTxt(livro1);
                livroControle.ExportarParaTxt(livro2);
                Console.WriteLine("\nDados de Livros gravados em TXT com sucesso.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao exportar Livro: " + e.Message);
            }
            Console.ReadKey(); //pausar
        }
    }
}
