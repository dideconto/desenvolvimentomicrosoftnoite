using System.Collections.Generic;
using System.Linq;
using VendasWPF.Models;

namespace VendasWPF.DAL
{
    class ProdutoDAO
    {
        private static Context _context = new Context();
        public static Produto BuscarPorNome(string nome) =>
            _context.Produtos.FirstOrDefault(x => x.Nome == nome);
        public static bool Cadastrar(Produto produto)
        {
            if (BuscarPorNome(produto.Nome) == null)
            {
                _context.Produtos.Add(produto);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public static void Remover(Produto produto)
        {
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
        }
        public static void Alterar(Produto produto)
        {
            _context.Produtos.Update(produto);
            _context.SaveChanges();
        }
        public static List<Produto> Listar() =>
            _context.Produtos.ToList();
        public static Produto BuscarPorId(int id) =>
            _context.Produtos.Find(id);
    }
}
