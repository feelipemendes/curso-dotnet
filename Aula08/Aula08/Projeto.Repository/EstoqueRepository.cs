using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //importando..
using Projeto.Entities; //importando..

namespace Projeto.Repository
{
    public class EstoqueRepository : Conexao
    {
        //método para inserir um estoque na base de dados..
        public void Inserir(Estoque estoque)
        {
            //criando a query sql..
            string query = "insert into Estoque(Nome) values(@Nome)";

            //executando o comando sql no banco de dados..
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@Nome", estoque.Nome);
            Command.ExecuteNonQuery(); //finaliza e executa
        }

        public void Atualizar(Estoque estoque)
        {
            string query = "update Estoque set Nome = @Nome" +
                "where IdEstoque = @IdEstoque";

            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@IdEstoque", estoque.IdEstoque);
            Command.Parameters.AddWithValue("@Nome", estoque.Nome);
            Command.ExecuteNonQuery();
        }
    }
}
