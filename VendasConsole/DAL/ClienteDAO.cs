using System.Collections.Generic;
using VendasConsole.Models;

namespace VendasConsole.DAL
{
    class ClienteDAO
    {
        private static List<Cliente> clientes = new List<Cliente>();
        public static List<Cliente> Listar() => clientes;
        public static bool Cadastrar(Cliente c)
        {
            if (BuscarCliente(c.Cpf) == null)
            {
                clientes.Add(c);
                return true;
            }
            return false;
        }
        public static Cliente BuscarCliente(string cpf)
        {
            foreach (Cliente clienteCadastrado in clientes)
            {
                if (clienteCadastrado.Cpf == cpf)
                {
                    return clienteCadastrado;
                }
            }
            return null;
        }
    }
}
