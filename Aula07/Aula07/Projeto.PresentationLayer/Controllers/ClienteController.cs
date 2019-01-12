using Projeto.BusinessLayer.Entities;
using Projeto.PresentationLayer.Models;
using ProjetoDataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto.PresentationLayer.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost] //receber um SUBMIT de formulário
        public ActionResult CadastrarCliente(ClienteCadastroViewModel model)
        {
            //verificar se todos os campo da Model passaram
            //nas regras de validação (Required, MinLength etc..)
            if (ModelState.IsValid)
            {
                try
                {
                    //instanciar a classe cliente..
                    Cliente cliente = new Cliente();
                    cliente.Nome = model.Nome;
                    cliente.Email = model.Email;
                    cliente.DataCadastro = DateTime.Now;
                    ClienteBusiness business = new ClienteBusiness();
                    business.CadastrarCliente(cliente);
                    ViewBag.Mensagem = "Cliente cadastrado com sucesso.";
                }
                catch (Exception e)
                {
                    ViewBag.Mensagem = e.Message;
                }
            }
            //retornar para a página..
            return View("Cadastro"); //nome da view..
        }
    }
}