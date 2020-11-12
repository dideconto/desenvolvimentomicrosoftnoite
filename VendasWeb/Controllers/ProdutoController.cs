using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.IO;
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
        private readonly CategoriaDAO _categoriaDAO;
        private readonly IWebHostEnvironment _hosting;
        public ProdutoController(ProdutoDAO produtoDAO,
            IWebHostEnvironment hosting,
            CategoriaDAO categoriaDAO)
        {
            _produtoDAO = produtoDAO;
            _categoriaDAO = categoriaDAO;
            _hosting = hosting;
        }
        public IActionResult Index()
        {
            ViewBag.Title = "Gerenciamento de Produtos";
            return View(_produtoDAO.Listar());
        }
        public IActionResult Cadastrar()
        {
            ViewBag.Categorias = new SelectList(_categoriaDAO.Listar(), "Id", "Nome");
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Produto produto, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    string arquivo = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
                    string caminho = Path.Combine(_hosting.WebRootPath, "images", arquivo);
                    file.CopyTo(new FileStream(caminho, FileMode.CreateNew));
                    produto.Imagem = arquivo;
                }
                else
                {
                    produto.Imagem = "semimagem.gif";
                }
                produto.Categoria = _categoriaDAO.BuscarPorId(produto.CategoriaId);
                if (_produtoDAO.Cadastrar(produto))
                {
                    return RedirectToAction("Index", "Produto");
                }
                ModelState.AddModelError("", "Já existe um produto com o mesmo nome!");
            }
            ViewBag.Categorias = new SelectList(_categoriaDAO.Listar(), "Id", "Nome");
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
