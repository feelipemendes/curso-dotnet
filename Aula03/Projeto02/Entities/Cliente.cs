using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Entities
{
    public class Cliente
    {
        //atributos
        private int idCliente;
        private string nome;
        private string email;

        //construtor [ctor] + 2x[tab]
        public Cliente()
        {
            //vazio..
        }

        //sobrecarga de métodos (overloading)
        public Cliente(int idCliente, string nome, string email)
        {
            IdCliente = idCliente;
            Nome = nome;
            Email = email;
        }

        //métodos de encapsulamento
        public int IdCliente
        {
            set { idCliente = value; }
            get { return idCliente; }
        }

        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }

        public string Email
        {
            set { email = value; }
            get { return email; }
        }
    }
}
