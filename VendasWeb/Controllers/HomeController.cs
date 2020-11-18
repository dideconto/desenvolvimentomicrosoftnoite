using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendasWeb.DAL;
using VendasWeb.Models;
using VendasWeb.Utils;

namespace VendasWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProdutoDAO _produtoDAO;
        private readonly CategoriaDAO _categoriaDAO;
        private readonly ItemVendaDAO _itemVendaDAO;
        private readonly Sessao _sessao;
        public HomeController(ProdutoDAO produtoDAO,
            CategoriaDAO categoriaDAO, ItemVendaDAO itemVendaDAO, Sessao sessao)
        {
            _produtoDAO = produtoDAO;
            _categoriaDAO = categoriaDAO;
            _itemVendaDAO = itemVendaDAO;
            _sessao = sessao;
        }
        public IActionResult Index(int id)
        {
            ViewBag.Categorias = _categoriaDAO.Listar();
            List<Produto> produtos =
                id == 0 ?
                _produtoDAO.Listar() :
                _produtoDAO.ListarPorCategoria(id);
            return View(produtos);
        }

        public IActionResult AdicionarAoCarrinho(int id)
        {
            Produto produto = _produtoDAO.BuscarPorId(id);
            ItemVenda item = new ItemVenda
            {
                Produto = produto,
                Preco = produto.Preco,
                Quantidade = 1,
                CarrinhoId = _sessao.BuscarCarrinhoId()
            };
            _itemVendaDAO.Cadastrar(item);
            return RedirectToAction("CarrinhoCompras");
        }

        public IActionResult CarrinhoCompras()
        {
            ViewBag.Title = "Carrinho de compras";
            string carrinhoId = _sessao.BuscarCarrinhoId();
            ViewBag.Total = _itemVendaDAO.SomarTotalCarrinho(carrinhoId);
            return View(_itemVendaDAO.ListarPorCarrinhoId(carrinhoId));
        }
    }
}

//Ajustes e Funcionalidade novas do CARRINHO DE COMPRAS
//    - FEITO - Ajustar dados da tabela (Nome, imagem, preco, quantidade, subtotal e etc...);
//    - Caso o produto já exista no carrinho, alterar a sua quantidade;
//    - Adicionar links para aumentar e diminuir a quantidade do item;
//    - Adicionar um link para remover todo o item do carrinho;
//    - FEITO - Criar uma Viewbag para mostrar o total do carrinho;
//    - Criar um link na barra de navegação para abrir o carrinho de compras;
//    - Mostrar a quantidade de itens dentro do carrinho na barra de navegação;
//    - Um para finalizar a compra;
