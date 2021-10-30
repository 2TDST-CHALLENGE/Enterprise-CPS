using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationForChallenge.Models;
using WebApplicationForChallenge.Persistencia;
using WebApplicationForChallenge.ViewModels;

namespace WebApplicationForChallenge.Controllers
{
    public class EstabelecimentoController : Controller
    {
        private IEstabelecimentoRepository _estabelecimentoRepository;
        private IProdutoRepository _produtoRepository;
        private IEstabelecimentoProdutoRepository _estabelecimentoProdutoRepository;
        //Receber por injeção de dependência o Context no construtor
        public EstabelecimentoController(IEstabelecimentoRepository estabelecimentoRepository,
                                           IProdutoRepository produtoRepository, IEstabelecimentoProdutoRepository estabelecimentoProdutoRepository)
        {
            _estabelecimentoRepository = estabelecimentoRepository;
            _produtoRepository = produtoRepository;
            _estabelecimentoProdutoRepository = estabelecimentoProdutoRepository;
        }

        [HttpPost]
        public IActionResult Adicionar(EstabelecimentoProduto estabelecimentoProduto)
        {
            //Cadastrar o produto estabelecimento
            _estabelecimentoProdutoRepository.Cadastrar(estabelecimentoProduto);
            _estabelecimentoProdutoRepository.Salvar();
            //Mensagem de sucesso
            TempData["msg"] = "Produto adicionado!";
            //Redirect
            return RedirectToAction("Detalhes", new { id = estabelecimentoProduto.Codigo });
        }

        [HttpGet]
        public IActionResult Detalhes(int id)
        {
            //Pesquisar todos os produtos que estão disponíveis
            var lista = _produtoRepository.BuscarPor(b => b.Disponivel);

            //Pesquisar todos os produtos que estão associados ao Estabelecimento
            var produtosEstabelecimento = _produtoRepository.BuscarPorEstabelecimento(id);

            //Filtrar a lista
            var listaFiltrada = lista.Where(b => !produtosEstabelecimento.Any(b1 => b.ProdutoId == b1.ProdutoId));


            var viewModel = new DetalhesEstabelecimentoViewModel()
            {
                Funcionario = _estabelecimentoRepository.BuscarPorId(id),
                Select = new SelectList(listaFiltrada, "ProdutoId", "Nome"),
                Lista = produtosEstabelecimento
            };

            //Enviar o estabelecimento para a view
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Cadastrar(Estabelecimento estabelecimento)
        {
            if (ModelState.IsValid)
            {
                _estabelecimentoRepository.Cadastrar(estabelecimento);
                _estabelecimentoRepository.Salvar();
                TempData["msg"] = "Cadastro registrado!";
            }
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
            if (ModelState.IsValid)
            {
                _estabelecimentoRepository.Atualizar(estabelecimento);
                _estabelecimentoRepository.Salvar();
                TempData["msg"] = "Cadastro atualizado!";
            }
            return Editar(estabelecimento.Codigo);
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            CarregarRamos();
            var estabelecimento = _estabelecimentoRepository.Find(p => p.Codigo == id);

            return View(estabelecimento);
        }

        [HttpPost]
        public IActionResult Remover(int id)
        {
            _estabelecimentoRepository.Remover(id);
            _estabelecimentoRepository.Salvar();
            TempData["msg"] = "Estabelecimento removido!";

            return RedirectToAction("Index");
        }

        public IActionResult Index(string nomeBusca)
        {
            var viewModel = new IndexEstabelecimentoViewModel()
            {
                Lista = _estabelecimentoRepository.BuscarPor(f =>
                (f.Nome.Contains(nomeBusca) || nomeBusca == null))
            };

            return View(viewModel);
        }
    }
}