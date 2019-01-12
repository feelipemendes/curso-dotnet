using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDataLayer.Entities
{
    public class Cliente
    {
        //propriedades [prop] + 2x[tab]
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        //construtor default [ctor] + 2x[tab]
        public Cliente()
        {
            //vazio
        }
        //sobrecarga de método (overloading)
        public Cliente(int idCliente, string nome,
        string email, DateTime dataCadastro)
        {
            IdCliente = idCliente;
            Nome = nome;
            Email = email;
            DataCadastro = dataCadastro;
        }
    }
}
