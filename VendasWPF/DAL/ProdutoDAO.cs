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
    }
}
