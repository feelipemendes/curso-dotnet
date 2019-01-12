using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDataLayer.Repository
{
    public class Conexao_
    {
        //propriedades [prop] + 2x[tab]
        public SqlConnection Connection { get; set; }
        public SqlCommand Command { get; set; }
        public SqlDataReader DataReader { get; set; }
        //método para abrir conexão com o banco de dados
        public void AbrirConexao()
        {
            Connection = new SqlConnection(ConfigurationManager.ConnectionStrings
            ["AULA07"].ConnectionString);
            Connection.Open(); //conectado..
        }
        public void FecharConexao()
        {
            Connection.Close(); //desconectado..
        }
    }
}
