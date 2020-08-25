using System;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class ListarProdutos
    {
        public static void Renderizar()
        {
            Console.WriteLine(" ---- LISTAR PRODUTOS ---- \n");
            foreach (Produto produtoCadastrado in ProdutoDAO.Listar())
            {
                Console.WriteLine(produtoCadastrado);
            }
        }
    }
}
