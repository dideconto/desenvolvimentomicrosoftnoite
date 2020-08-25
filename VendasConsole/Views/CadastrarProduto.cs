using System;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class CadastrarProduto
    {
        public static void Renderizar()
        {
            Produto p = new Produto();
            Console.WriteLine(" ---- CADASTRAR PRODUTO ---- \n");
            Console.WriteLine("Digite o nome do produto:");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Digite o preço do cliente:");
            p.Preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do cliente:");
            p.Quantidade = Convert.ToInt32(Console.ReadLine());
            if (ProdutoDAO.Cadastrar(p))
            {
                Console.WriteLine("Produto cadastrado com sucesso!!!");
            }
            else
            {
                Console.WriteLine("Esse produto já existe!!!");
            }
        }
    }
}
