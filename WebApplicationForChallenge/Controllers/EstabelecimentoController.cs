using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplicationForChallenge.Models;

namespace WebApplicationForChallenge.Controllers
{
    public class EstabelecimentoController : Controller
    {
        private static List<Estabelecimento> _banco = new List<Estabelecimento>();
        private static int _gerador = 1;
        public IActionResult Index() { return View(_banco); }

        [HttpPost]
        public IActionResult Cadastrar(Estabelecimento estabelecimento)
        {
            estabelecimento.Codigo = _gerador++;
            _banco.Add(estabelecimento);
            TempData["msg"] = "Cadastro registrado!";

            return RedirectToAction("cadastrar");
        }

        [HttpGet] //Abrir a página de cadastro - URL /estabelecimento/cadastrar
        public IActionResult Cadastrar()
        {
            CarregarRamos();
            return View();
        }

        private void CarregarRamos()
        {
            var lista = new List<string>(new string[] { "Supermercado", "Varejista", "Livraria" });
            ViewBag.Ramo = new SelectList(lista);
        }

        [HttpPost]
        public IActionResult Editar(Estabelecimento estabelecimento)
        {
            _banco[_banco.FindIndex(p => p.Codigo == estabelecimento.Codigo)] = estabelecimento;
            TempData["msg"] = "Cadastro atualizado!";

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            CarregarRamos();
            var estabelecimento = _banco.Find(p => p.Codigo == id);

            return View(estabelecimento);
        }

        [HttpPost]
        public IActionResult Remover(int id)
        {
            _banco.RemoveAll(p => p.Codigo == id);
            TempData["msg"] = "Estabelecimento removido!";

            return RedirectToAction("Index");
        }
    }
}