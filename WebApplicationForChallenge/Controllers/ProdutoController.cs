using WebApplicationForChallenge.Models;
using WebApplicationForChallenge.Persistencia;
using WebApplicationForChallenge.Repositories;
using WebApplicationForChallenge.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationForChallenge.Controllers
{
    public class ProdutoController : Controller
    {
        private IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IActionResult Index()
        {
            return View(CarregarViewModel());
        }

        private ProdutoViewModel CarregarViewModel()
        {
            return new ProdutoViewModel()
            {
                Lista = _produtoRepository.Listar()
            };
        }

        [HttpPost]
        public IActionResult Cadastrar(Produto produto)
        {
            if (ModelState.IsValid)
            {
                _produtoRepository.Cadastrar(produto);
                _produtoRepository.Salvar();
                TempData["msg"] = "Produto registrado";
                return RedirectToAction("Index");
            }
            return View("Index", CarregarViewModel());
        }
    }
}