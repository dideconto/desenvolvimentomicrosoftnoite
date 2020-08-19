using System;

namespace VendasConsole.Views
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine(" ---- APLICAÇÃO DE VENDAS ---- \n");
                Console.WriteLine("1 - Cadastrar cliente");
                Console.WriteLine("2 - Listar clientes");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("\nDigite a opção desejada:");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        CadastrarCliente.Renderizar();
                        break;
                    case 2:
                        ListarClientes.Renderizar();
                        break;
                    case 3:
                        string idade = (15 > 18) ? "Maior" : "Menor";
                        Console.WriteLine(idade);
                        break;
                    case 0:
                        Console.WriteLine("Saindo...\n");
                        break;
                    default:
                        Console.WriteLine(" ---- OPÇÃO INVÁLIDA!!! ---- \n");
                        break;
                }
                Console.WriteLine("\nPressione uma tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }
    }
}
