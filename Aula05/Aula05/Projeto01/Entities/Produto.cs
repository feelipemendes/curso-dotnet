using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entities
{
    public class Produto
    {
        //encapsulamento implicito
        //[prop] + 2x[tab]
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        //construtor default [ctor] + 2x[tab]
        public Produto()
        {
            //vazio
        }
        //sobrecarga de método (overloading)
        public Produto(int idProduto, string nome, decimal preco,
        DateTime dataCadastro)
        {
            IdProduto = idProduto;
            Nome = nome;
            Preco = preco;
            DataCadastro = dataCadastro;
        }
    }
}
