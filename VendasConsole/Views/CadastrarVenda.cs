using System;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class CadastrarVenda
    {
        public static void Renderizar()
        {
            //Ctrl + K + C -> Comentário
            //Ctrl + K + U -> Descomentar
            Venda venda = new Venda();
            Cliente c = new Cliente();
            Vendedor v = new Vendedor();
            Produto p = new Produto();
            ItemVenda iv = new ItemVenda();

            Console.WriteLine(" ---- CADASTRAR VENDA ---- \n");
            Console.WriteLine("Digite o CPF do cliente:");

            //Cliente
            c.Cpf = Console.ReadLine();
            c = ClienteDAO.BuscarCliente(c.Cpf);
            if (c != null)
            {
                venda.Cliente = c;
                //Vendedor
                Console.WriteLine("Digite o CPF do vendedor:");
                v.Cpf = Console.ReadLine();
                v = VendedorDAO.BuscarVendedor(v.Cpf);
                if (v != null)
                {
                    venda.Vendedor = v;
                    do
                    {
                        iv = new ItemVenda();
                        p = new Produto();
                        Console.Clear();
                        Console.WriteLine(" ---- ADICIONAR PRODUTO ---- \n");

                        Console.WriteLine("Digite o nome do produto:");
                        p.Nome = Console.ReadLine();
                        p = ProdutoDAO.BuscarProduto(p.Nome);
                        if (p != null)
                        {
                            iv.Produto = p;
                            Console.WriteLine("Digite a quantidade do produto:");
                            iv.Quantidade = Convert.ToInt32(Console.ReadLine());
                            iv.Preco = p.Preco;
                            venda.Itens.Add(iv);
                        }
                        else
                        {
                            Console.WriteLine("Produto não encontrado!");
                        }
                        Console.WriteLine("\nDeseja adicionar mais produtos? (S/N)");
                    } while (Console.ReadLine().ToUpper().Equals("S"));
                    //Cadastrar Venda
                    VendaDAO.Cadastrar(venda);
                    Console.WriteLine("Venda cadastrada com sucesso!!!");
                }
                else
                {
                    Console.WriteLine("Vendedor não encontrado!");
                }
            }
            else
            {
                Console.WriteLine("Cliente não encontrado!");
            }
        }
    }
}
