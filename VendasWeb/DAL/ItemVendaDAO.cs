using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using VendasWeb.Models;

namespace VendasWeb.DAL
{
    public class ItemVendaDAO
    {
        private readonly Context _context;
        public ItemVendaDAO(Context context) => _context = context;
        public void Cadastrar(ItemVenda item)
        {
            _context.ItensVenda.Add(item);
            _context.SaveChanges();
        }
        public List<ItemVenda> ListarPorCarrinhoId(string id) =>
            _context.ItensVenda.AsNoTracking().
            Include(x => x.Produto.Categoria).
            Where(x => x.CarrinhoId == id).ToList();

        public double SomarTotalCarrinho(string id) =>
            ListarPorCarrinhoId(id).Sum(x => x.Quantidade * x.Preco);
    }
}
//public Categoria BuscarPorId(int id) => _context.Categorias.Find(id);
