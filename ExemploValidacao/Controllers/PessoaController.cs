using ExemploValidacao.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploValidacao.Controllers
{
    public class PessoaController : Controller
    {
        // GET: Pessoa
        public ActionResult Index()
        {
            var pessoa = new Pessoa();
            return View();
        }

        [HttpPost]
        public ActionResult Index(Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", pessoa);
            }

            return View(pessoa);
        }

        public ActionResult Resultado(Pessoa pessoa)
        {
            return View(pessoa);
        }

        public ActionResult LoginUnico(string login)
        {
            var bancoDeNomesDeExemplo = new Collection<string>
            {
                "Cleyton",
                "Anderson",
                "Ederson",
                "Renata"
            };

            return Json(bancoDeNomesDeExemplo.All(x => x.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}