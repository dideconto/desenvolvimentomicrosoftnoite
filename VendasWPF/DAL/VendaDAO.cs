using VendasWPF.Models;

namespace VendasWPF.DAL
{
    class VendaDAO
    {
        private static Context _context = SingletonContext.GetInstance();
        public static void Cadastrar(Venda venda)
        {
            _context.Vendas.Add(venda);
            _context.SaveChanges();
        }
    }
}
