using Projeto01.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Impressao
{
    public class ClienteImpressao
    {
        public void Imprimir(Cliente cliente)
        {
            Console.WriteLine("\nImpressão de Cliente: \n");
            Console.WriteLine("Id do Cliente.: " + cliente.IdPessoa);
            Console.WriteLine("Nome..........: " + cliente.Nome);
            Console.WriteLine("CPF do Cliente: " + cliente.Cpf);
            Console.WriteLine("Email.........: " + cliente.Email);
            Console.WriteLine("Estado........: " + cliente.Endereco.Estado);
            Console.WriteLine("Cidade........: " + cliente.Endereco.Cidade);
            Console.WriteLine("Lograd........: " + cliente.Endereco.Logradouro);
            Console.WriteLine("CEP...........: " + cliente.Endereco.Cep);

            Console.WriteLine("..");
        }
    }
}
