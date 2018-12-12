using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02
{
    public class Funcionario
    {
        private int idFuncionario;
        private string nome;
        private decimal salario;
        private TipoContratacao tipoContratacao;

        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public TipoContratacao TipoContratacao { get; set; }
    }
}
