using System.Collections.Generic;
using System.Linq;
using VendasWeb.Models;

namespace VendasWeb.DAL
{
    public class ProdutoDAO
    {
        private readonly Context _context;
        public ProdutoDAO(Context context) => _context = context;
        public List<Produto> Listar() => _context.Produtos.ToList();
        public Produto BuscarPorId(int id) => _context.Produtos.Find(id);
        public void Cadastrar(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }
        public void Remover(int id)
        {
            _context.Produtos.Remove(BuscarPorId(id));
            _context.SaveChanges();
        }
        public void Alterar(Produto produto)
        {
            _context.Produtos.Update(produto);
            _context.SaveChanges();
        }
    }
}
