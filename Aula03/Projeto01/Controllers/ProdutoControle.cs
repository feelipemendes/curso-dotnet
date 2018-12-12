using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities; //importando..
using System.IO; //input, output..
using Newtonsoft.Json; //biblioteca para JSON

namespace Projeto01.Controllers
{
    public class ProdutoControle
    {
        //método para exportar os dados de um produto
        //para arquivo .JSON
        public void ExportarDados(Produto produto)
        {
            //criando um arquivo com extensão .json
            StreamWriter streamWriter = new StreamWriter("c:\\temp\\produto.json");

            //serializar os dados do objeto para JSON (objeto -> json)
            string json = JsonConvert.SerializeObject(produto, Formatting.Indented);

            //escrevendo no arquivo..
            streamWriter.WriteLine(json);

            //fechando o arquivo
            streamWriter.Close();
        }

        //método para importar os dados do produto
        //contido no arquivo .JSON
        public Produto ImportarDados()
        {
            //abrindo um arquivo em modo de leitura
            StreamReader streamReader = new StreamReader("c:\\temp\\produto.json");

            //ler todo o conteudo do arquivo e armazenar em uma variavel texto..
            string json = streamReader.ReadToEnd();

            //fechar o arquivo..
            streamReader.Close();

            //deserializar o conteudo JSON (json -> objeto)
            Produto produto = JsonConvert.DeserializeObject<Produto>(json);

            //retornar o produto..
            return produto;
        }
    }
}
