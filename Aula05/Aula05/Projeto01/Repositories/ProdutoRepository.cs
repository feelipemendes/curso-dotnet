using Projeto01.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Repositories
{
    public class ProdutoRepository : Conexao
    {
        public void Inserir(Produto produto)
        {
            Command = new SqlCommand("SpInserirProduto", Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@Nome", produto.Nome);
            Command.Parameters.AddWithValue("@Preco", produto.Preco);
            Command.ExecuteNonQuery();
        }
        public void Atualizar(Produto produto)
        {
            Command = new SqlCommand("SpAtualizarProduto", Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@IdProduto", produto.IdProduto);
            Command.Parameters.AddWithValue("@Nome", produto.Nome);
            Command.Parameters.AddWithValue("@Preco", produto.Preco);
            Command.ExecuteNonQuery();
        }
        public void Excluir(int idProduto)
        {
            Command = new SqlCommand("SpExcluirProduto", Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@IdProduto", idProduto);
            Command.ExecuteNonQuery();
        }
        public List<Produto> Consultar()
        {
            Command = new SqlCommand("SpConsultarProdutos", Connection);
            Command.CommandType = CommandType.StoredProcedure;
            DataReader = Command.ExecuteReader();
            List<Produto> lista = new List<Produto>();
            while (DataReader.Read())
            {
                Produto produto = new Produto();
                produto.IdProduto = Convert.ToInt32(DataReader["IdProduto"]);
                produto.Nome = Convert.ToString(DataReader["Nome"]);
                produto.Preco = Convert.ToDecimal(DataReader["Preco"]);
                produto.DataCadastro = Convert.ToDateTime
                (DataReader["DataCadastro"]);

                lista.Add(produto); //adicionar na lista..
            }
            return lista; //retornando..
        }
    }
}
