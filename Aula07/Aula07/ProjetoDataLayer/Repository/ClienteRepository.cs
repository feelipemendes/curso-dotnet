using ProjetoDataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDataLayer.Repository
{
    public class ClienteRepository : Conexao_
    {
        //método para gravar um cliente na tabela do banco..
        public void Inserir(Cliente cliente)
        {
            //comando em linguagem SQL..
            string query = "insert into Cliente(Nome, Email, DataCadastro) "
            + "values(@Nome, @Email, @DataCadastro)";
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@Nome", cliente.Nome);
            Command.Parameters.AddWithValue("@Email", cliente.Email);
            Command.Parameters.AddWithValue("@DataCadastro",
            cliente.DataCadastro);
            Command.ExecuteNonQuery();
        }
    }
}
