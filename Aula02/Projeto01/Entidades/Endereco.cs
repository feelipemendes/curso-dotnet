using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entidades
{
    public class Endereco
    {
        private int idEndereco;
        private string logradouro;
        private string cidade;
        private string estado;
        private string cep;

        public int IdEndereco { get; set; }
        public string Logradouro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string  Cep { get; set; }
    }
}
