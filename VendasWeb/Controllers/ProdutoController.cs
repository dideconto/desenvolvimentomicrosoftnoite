using Microsoft.AspNetCore.Mvc;
using VendasWeb.DAL;
using VendasWeb.Models;

namespace VendasWeb.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ProdutoDAO _produtoDAO;
        public ProdutoController(ProdutoDAO produtoDAO) => _produtoDAO = produtoDAO;
        public IActionResult Index()
        {
            ViewBag.Produtos = _produtoDAO.Listar();
            return View();
        }
        public IActionResult Cadastrar() => View();

        [HttpPost]
        public IActionResult Cadastrar(string Nome, string Descricao, int Quantidade,
           double Preco)
        {
            Produto produto = new Produto
            {
                Nome = Nome,
                Descricao = Descricao,
                Quantidade = Quantidade,
                Preco = Preco
            };
            _produtoDAO.Cadastrar(produto);
            return RedirectToAction("Index", "Produto");
        }
        public IActionResult Remover(int id)
        {
            _produtoDAO.Remover(id);
            return RedirectToAction("Index", "Produto");
        }
        public IActionResult Alterar(int id)
        {
            ViewBag.Produto = _produtoDAO.BuscarPorId(id);
            return View();
        }
        [HttpPost]
        public IActionResult Alterar(string Nome, string Descricao, int Quantidade,
           double Preco, int Id, int HdnId)
        {
            Produto produto = _produtoDAO.BuscarPorId(Id);
            produto.Nome = Nome;
            produto.Descricao = Descricao;
            produto.Quantidade = Quantidade;
            produto.Preco = Preco;

            _produtoDAO.Alterar(produto);
            return RedirectToAction("Index", "Produto");
        }
    }
}
