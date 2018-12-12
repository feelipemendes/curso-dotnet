using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entidades
{
    public class Cliente : Pessoa
    {
        private string cpf;
        private string email;
        private Endereco endereco;

        public string Cpf { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }
    }
}
