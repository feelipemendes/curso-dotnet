using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entities; //importando..

namespace Projeto02
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarando uma lista de clientes..
            List<Cliente> lista = new List<Cliente>();

            //laço for..
            for (int i = 0; i < 3; i++)
            {
                Cliente cliente = new Cliente();

                Console.WriteLine($"\nENTRE COM O {i+1}º CLIENTE:\n");

                Console.Write("Id do Cliente......: ");
                cliente.IdCliente = int.Parse(Console.ReadLine());

                Console.Write("Nome do Cliente....: ");
                cliente.Nome = Console.ReadLine();

                Console.Write("Email do Cliente...: ");
                cliente.Email = Console.ReadLine();

                //adicionando na lista..
                lista.Add(cliente);
            }

            Console.WriteLine("\nQUANTIDADE DE CLIENTES: " + lista.Count);

            //varrendo todos os elementos da lista..
            foreach(Cliente registro in lista)
            {
                Console.WriteLine("\tID.....: " + registro.IdCliente);
                Console.WriteLine("\tNOME...: " + registro.Nome);
                Console.WriteLine("\tEMAIL..: " + registro.Email);
                Console.WriteLine("\t--");
            }
            
            //pausar a execução..
            Console.ReadKey();
        }
    }
}
