using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities; //importando..
using Projeto01.Controllers; //importando..
using System.IO;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto(1, "Notebook", 2000.0m, 10);

            //imprimindo..
            Console.WriteLine("\nDADOS DO PRODUTO:\n");

            Console.WriteLine("Código.......: " + produto.IdProduto);
            Console.WriteLine("Nome.........: " + produto.Nome);
            Console.WriteLine("Preço........: " + produto.Preco);
            Console.WriteLine("Quantidade...: " + produto.Quantidade);

            //gerando o arquivo JSON..
            ProdutoControle produtoControle = new ProdutoControle();

            try //tentativa
            {
                produtoControle.ExportarDados(produto);
                Console.WriteLine("\nDados gravados com sucesso.");
            }
            catch(UnauthorizedAccessException e)
            {
                Console.WriteLine("\nAcesso negado ao diretório: " + e.Message);
            }
            catch(DirectoryNotFoundException e)
            {
                Console.WriteLine("\nDiretório não encontrado: " + e.Message);
            }
            catch(Exception e) //captura da exceção
            {
                Console.WriteLine("\nOcorreu um erro: " + e.Message);
            }       
            

            try
            {
                Produto registro = produtoControle.ImportarDados();

                //imprimindo..
                Console.WriteLine("\nDADOS OBTIDOS DO ARQUIVO:\n");
                Console.WriteLine($"Id: {registro.IdProduto}, Nome: {registro.Nome}, Preço: {registro.Preco}, Quantidade: {registro.Quantidade}");
            }
            catch(Exception e)
            {
                Console.WriteLine("\nOcorreu um erro: " + e.Message);
            }

            //pausar..
            Console.ReadKey();
        }
    }    
}
