using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationForChallenge.Models;
using WebApplicationForChallenge.Persistencia;

namespace WebApplicationForChallenge.Controllers
{
    public class EstabelecimentoController : Controller
    {
        private FabricaContext _context;

        //Receber por injeção de dependência o Context no construtor
        public EstabelecimentoController(FabricaContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Cadastrar(Estabelecimento estabelecimento)
        {
            _context.Estabelecimentos.Add(estabelecimento);
            _context.SaveChanges();//commit
            TempData["msg"] = "Estabelecimento cadastrado!";
            return RedirectToAction("Index");
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
            _context.Estabelecimentos.Update(estabelecimento);
            _context.SaveChanges();
            TempData["msg"] = "Estabelecimento atualizado";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            CarregarRamos();
            var estabelecimento = _context.Estabelecimentos
                .Include(f => f.Endereco) //inclui o relacionamento
                .Where(f => f.Codigo == id) //filtro
                .FirstOrDefault(); //retorna o primeiro resultado ou null
            return View(estabelecimento);
        }

        [HttpPost]
        public IActionResult Remover(int id)
        {
            var estabelecimento = _context.Estabelecimentos.Find(id); //pesquisa pela PK
            _context.Estabelecimentos.Remove(estabelecimento); //remove pelo objeto
            _context.SaveChanges(); //commit
            TempData["msg"] = "Estabelecimento removido!";
            return RedirectToAction("Index");
        }

        public IActionResult Index(string nomeBusca)
        {
            var lista = _context.Estabelecimentos.Where(f =>
                (f.Nome.Contains(nomeBusca) || nomeBusca == null))
                .Include(f => f.Nome)
                .Include(f => f.Endereco) //Inclui o endereço no resultado da pesquisa
                .ToList(); //recupera todos os estabelecimento
            return View(lista);
        }

    }
}