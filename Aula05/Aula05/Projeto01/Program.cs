using Projeto01.Entities;
using Projeto01.Repositories;
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
            ProdutoRepository repository = new ProdutoRepository();
            try
            {
                repository.AbrirConexao();
                Console.WriteLine("\nCONTROLE DE PRODUTOS\n");
                Console.WriteLine("(1) Inserir Produto");
                Console.WriteLine("(2) Atualizar Produto");
                Console.WriteLine("(3) Excluir Produto");
                Console.WriteLine("(4) Consultar Produtos");
                Console.Write("\nEscolha a opção desejada..: ");
                int opcao = int.Parse(Console.ReadLine());
                Produto produto = new Produto();
                switch (opcao)
                {
                    case 1:
                        Console.Write("Nome do Produto...: ");
                        produto.Nome = Console.ReadLine();
                        Console.Write("Preço do Produto..: ");
                        produto.Preco = decimal.Parse(Console.ReadLine());
                        repository.Inserir(produto);
                        Console.WriteLine("\nProduto cadastrado com sucesso.");
                        break;

                    case 2:
                        Console.Write("Id do Produto.....: ");
                        produto.IdProduto = int.Parse(Console.ReadLine());
                        Console.Write("Nome do Produto...: ");
                        produto.Nome = Console.ReadLine();
                        Console.Write("Preço do Produto..: ");
                        produto.Preco = decimal.Parse(Console.ReadLine());
                        repository.Atualizar(produto);
                        Console.WriteLine("\nProduto atualizado com sucesso.");
                        break;
                    case 3:
                        Console.Write("Id do Produto.....: ");
                        int idProduto = int.Parse(Console.ReadLine());
                        repository.Excluir(idProduto);
                        Console.WriteLine("\nProduto excluido com sucesso.");
                        break;
                    case 4:
                        List<Produto> lista = repository.Consultar();
                        foreach (Produto item in lista)
                        {
                            Console.WriteLine("Id do Produto......: "
                            + item.IdProduto);
                            Console.WriteLine("Nome...............: "
                            + item.Nome);
                            Console.WriteLine("Preço..............: "
                            + item.Preco);
                            Console.WriteLine("Data de Cadastro...: "
                            + item.DataCadastro);
                            Console.WriteLine("...");
                        }
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida.");
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("\nErro: " + e.Message);
            }
            finally
            {
                repository.FecharConexao();
            }
            Console.ReadKey(); //pausar..
        }
    }
}
