using System.Collections.Generic;
using VendasConsole.Models;

namespace VendasConsole.DAL
{
    class VendedorDAO
    {
        private static List<Vendedor> vendedores = new List<Vendedor>();

        public static bool Cadastrar(Vendedor vendedor)
        {
            if (BuscarVendedor(vendedor.Cpf) != null)
            {
                return false;
            }
            vendedores.Add(vendedor);
            return true;
        }

        public static Vendedor BuscarVendedor(string cpf)
        {
            foreach (Vendedor vendedorCadastrado in vendedores)
            {
                if (cpf.Equals(vendedorCadastrado.Cpf))
                {
                    return vendedorCadastrado;
                }
            }
            return null;
        }

        public static List<Vendedor> Listar() => vendedores;

    }
}
