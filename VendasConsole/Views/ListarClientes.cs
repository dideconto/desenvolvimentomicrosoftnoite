using System;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class ListarClientes
    {
        public static void Renderizar()
        {
            Console.WriteLine(" ---- LISTAR CLIENTES ---- \n");
            foreach (Cliente clienteCadastrado in ClienteDAO.Listar())
            {
                Console.WriteLine(clienteCadastrado);
            }
        }
    }
}
