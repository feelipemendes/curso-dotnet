using Projeto01.Entidade;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Controle
{
    public class ProdutoControle
    {
        //Criando um metodo para Gravar produtos em um arquivo
        public void GravarArquivo(Produto produto)
        {
            StreamWriter streamWriter = new StreamWriter("c:\\Projetos\\dotNET\\COTI\\Aula01\\Arquivo\\produtos.txt", true);

            streamWriter.WriteLine("Codigo:"+produto.Codigo);
            streamWriter.WriteLine("Nome:" + produto.Nome);
            streamWriter.WriteLine("Preco:" + produto.Preco);
            streamWriter.WriteLine("Quantidade:" + produto.Quantidade);
            streamWriter.WriteLine("..");

            streamWriter.Close();

        }

    }
}
