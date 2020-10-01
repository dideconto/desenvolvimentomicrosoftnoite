using System.Collections.Generic;
using System.Linq;
using VendasWPF.Models;

namespace VendasWPF.DAL
{
    class ClienteDAO
    {
        private static Context _context = SingletonContext.GetInstance();
        public static List<Cliente> Listar() =>
               _context.Clientes.ToList();
        public static Cliente BuscarPorId(int id) =>
            _context.Clientes.Find(id);
    }
}
