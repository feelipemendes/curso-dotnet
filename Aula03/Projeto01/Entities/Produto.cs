using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace -> localização da classe
namespace Projeto01.Entities
{
    //definição da classe
    public class Produto
    {
        //atributos (dados)
        private int idProduto;
        private string nome;
        private decimal preco;
        private int quantidade;

        //método construtor [ctor] + 2x[tab]
        public Produto()
        {
            //vazio..
        }

        //método construtor [ctor] + 2x[tab]
        public Produto(int idProduto, string nome, decimal preco, int quantidade)
        {
            IdProduto = idProduto;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //métodos de encapsulamento (set/get)
        public int IdProduto
        {
            set { idProduto = value; } //entrada
            get { return idProduto; } //saida
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
