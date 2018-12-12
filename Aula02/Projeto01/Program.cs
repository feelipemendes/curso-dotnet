using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entidades;
using Projeto01.Impressao;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Endereco = new Endereco();

            cliente.IdPessoa = 1;
            cliente.Nome = "Sergio Mendes";
            cliente.Email = "sergio.coti@gmail.com";
            cliente.Cpf = "123.456.789-00";
            cliente.Endereco.IdEndereco = 1;
            cliente.Endereco.Logradouro = "Av Rio Branco, 185 Centro";
            cliente.Endereco.Cidade = "Rio de Janeiro";
            cliente.Endereco.Estado = "RJ";
            cliente.Endereco.Cep = "25000-000";

            ClienteImpressao ci = new ClienteImpressao();
            ci.Imprimir(cliente);

            Console.ReadKey();

        }
    }
}
