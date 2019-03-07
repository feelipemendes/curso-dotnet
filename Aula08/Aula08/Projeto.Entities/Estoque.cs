using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entities
{
    public class Estoque
    {
        //prop + 2xtab
        public int IdEstoque { get; set; }
        public string Nome { get; set; }

        //Relacionamento Associação (TER-MUITOS)
        public List<Produto> Produtos { get; set; }
    }
}
