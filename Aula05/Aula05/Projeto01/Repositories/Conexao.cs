using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Projeto01.Repositories
{
    public class Conexao
    {
        //propriedades..
        //[prop] + 2x[tab]
        public SqlConnection Connection { get; set; }
        public SqlCommand Command { get; set; }
        public SqlDataReader DataReader { get; set; }
        //método para abrir conexão com o banco de dados..
        public void AbrirConexao()
        {
            Connection = new SqlConnection(ConfigurationManager.ConnectionStrings
            ["AULA05"].ConnectionString);
            Connection.Open();
        }
        //método para fechar conexão com o banco de dados..
        public void FecharConexao()
        {
            if (Connection != null)
            {
                Connection.Close();
            }
        }
    }
}
