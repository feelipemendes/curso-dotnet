using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //importando..
using System.Configuration; //importando..

namespace Projeto.Repository
{
    public class Conexao
    {
        //utilizado para conexão com o sqlserver
        public SqlConnection Connection { get; set; }

        //utilizado para executar comandos sql
        public SqlCommand Command { get; set; }

        //utilizado para ler e retornar dados de consultas
        public SqlDataReader DataReader { get; set; }

        //método para abrir conexão com o banco de dados
        public void AbrirConexao()
        {
            Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["projeto"].ConnectionString);
            Connection.Open(); //conectado..
        }

        //método para fechar conexão com o banco de dados
        public void FecharConexao()
        {
            if(Connection != null)
            {
                Connection.Close(); //desconectar..
            }
        }
    }
}
