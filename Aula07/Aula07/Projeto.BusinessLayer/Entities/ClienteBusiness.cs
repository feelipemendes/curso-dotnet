using ProjetoDataLayer.Entities;
using ProjetoDataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.BusinessLayer.Entities
{
    public class ClienteBusiness
    {
        public void CadastrarCliente(Cliente cliente)
        {
            //instanciando a classe de repositorio..
            ClienteRepository repository = new ClienteRepository();
            repository.AbrirConexao();
            repository.Inserir(cliente);
            repository.FecharConexao();
        }
    }
}
