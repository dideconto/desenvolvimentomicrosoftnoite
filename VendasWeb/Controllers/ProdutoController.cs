using Microsoft.AspNetCore.Mvc;
using VendasWeb.DAL;
using VendasWeb.Models;

namespace VendasWeb.Controllers
{
    public class ProdutoController : Controller
    {
        //https://getbootstrap.com/
        //https://bootswatch.com/
        //https://www.w3schools.com/bootstrap4/default.asp

        private readonly ProdutoDAO _produtoDAO;
        public ProdutoController(ProdutoDAO produtoDAO) => _produtoDAO = produtoDAO;
        public IActionResult Index()
        {
            ViewBag.Title = "Gerenciamento de Produtos";
            return View(_produtoDAO.Listar());
        }
        public IActionResult Cadastrar() => View();

        [HttpPost]
        public IActionResult Cadastrar(Produto produto)
        {
            if (ModelState.IsValid)
            {
                if (_produtoDAO.Cadastrar(produto))
                {
                    return RedirectToAction("Index", "Produto");
                }
                ModelState.AddModelError("", "Já existe um produto com o mesmo nome!");
            }
            return View(produto);
        }
        public IActionResult Remover(int id)
        {
            _produtoDAO.Remover(id);
            return RedirectToAction("Index", "Produto");
        }
        public IActionResult Alterar(int id)
        {
            return View(_produtoDAO.BuscarPorId(id));
        }
        [HttpPost]
        public IActionResult Alterar(Produto produto)
        {
            _produtoDAO.Alterar(produto);
            return RedirectToAction("Index", "Produto");
        }
    }
}
