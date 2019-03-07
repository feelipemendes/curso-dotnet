using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto.Presentation.Models; //importando..
using Projeto.Entities; //importando..
using Projeto.Business; //importando..

namespace Projeto.Presentation.Controllers
{
    public class EstoqueController : Controller
    {
        // GET: Produto/Cadastro
        public ActionResult Cadastro()
        {
            return View();
        }

        // GET: Produto/Consulta
        public ActionResult Consulta()
        {
            return View();
        }

        // GET: Produto/Edicao
        public ActionResult Edicao()
        {
            return View();
        }

        [HttpPost] //receber chamadas do tipo POST
        public ActionResult CadastrarEstoque(EstoqueCadastroViewModel model)
        {
            //verificar se os dados estão corretos
            //em relação as suas validações..
            if(ModelState.IsValid)
            {
                Estoque estoque = new Estoque();
                estoque.Nome = model.Nome;

                try
                {
                    EstoqueBusiness business = new EstoqueBusiness();
                    business.Cadastrar(estoque);

                    ViewBag.Mensagem = "Estoque cadastrado com sucesso.";
                }
                catch(Exception e)
                {
                    ViewBag.Mensagem = e.Message;
                }
            }

            //retornar para a página..
            return View("Cadastro");
        }
    }
}