using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entidade
{
    public class Produto
    {
        private int codigo;
        private string nome;
        private decimal preco;
        private int quantidade;

        public int Codigo
        {
            set { codigo = value; }
            get { return codigo; }
        }

        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }

        public decimal Preco
        {
            set { preco = value; }
            get { return preco; }
        }

        public int Quantidade
        {
            set { quantidade = value; }
            get { return quantidade; }
        }

    }
}
