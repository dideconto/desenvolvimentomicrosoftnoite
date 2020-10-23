using Microsoft.AspNetCore.Mvc;
using VendasWeb.Models;

namespace VendasWeb.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly Context _context;
        public ProdutoController(Context context) => _context = context;
        public IActionResult Index()
        {
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
            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return RedirectToAction("Index", "Produto");
        }
    }
}
