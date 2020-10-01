using System.Collections.Generic;
using System.Linq;
using VendasWPF.Models;

namespace VendasWPF.DAL
{

    class VendedorDAO
    {
        private static Context _context = SingletonContext.GetInstance();
        public static List<Vendedor> Listar() =>
               _context.Vendedores.ToList();
        public static Vendedor BuscarPorId(int id) =>
            _context.Vendedores.Find(id);
    }
}
