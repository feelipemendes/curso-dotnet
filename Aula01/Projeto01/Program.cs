using Projeto01.Controle;
using Projeto01.Entidade;
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
            Console.WriteLine("Aula 01 - C# Developer");

            Console.WriteLine("Insira seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("\nSeja Bem vindo, " + nome);

            //-------------------------------------- Começo do Programa ---------------------------------------------//
            Produto produto = new Produto();

            Console.WriteLine("Informe o Codigo do produto: ");
            produto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Nome: ");
            produto.Nome = Console.ReadLine();

            Console.WriteLine("Informe o Preco: ");
            produto.Preco = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe a Quantidade: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nLista Produtos: \n");
            Console.WriteLine("Codigo:"+produto.Codigo);
            Console.WriteLine("Nome:" + produto.Nome);
            Console.WriteLine("Preco:" + produto.Preco);
            Console.WriteLine("Quantidade:" + produto.Quantidade);

            //Gravar arquivo
            ProdutoControle produtoControle = new ProdutoControle();
            produtoControle.GravarArquivo(produto);

            Console.WriteLine("Produto Gravado com sucesso!!");

            Console.ReadKey();

        }
    }
}
