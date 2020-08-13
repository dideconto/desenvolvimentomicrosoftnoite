using System;
using System.Collections.Generic;

namespace VendasConsole
{
    class Program
    {
        //Format On Save
        //https://www.geradorcpf.com/algoritmo_do_cpf.htm
        static void Main(string[] args)
        {
            int opcao;
            Cliente c;
            List<Cliente> clientes = new List<Cliente>();

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
                        c = new Cliente();
                        Console.WriteLine(" ---- CADASTRAR CLIENTE ---- \n");
                        Console.WriteLine("Digite o nome do cliente:");
                        c.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o cpf do cliente:");
                        c.Cpf = Console.ReadLine();

                        if (clientes.Count == 0)
                        {
                            clientes.Add(c);
                            Console.WriteLine("Cliente salvo com sucesso!!!");
                        }
                        else
                        {
                            bool encontrado = false;
                            foreach (Cliente clienteCadastrado in clientes)
                            {
                                if (clienteCadastrado.Cpf == c.Cpf)
                                {
                                    encontrado = true;
                                }
                            }
                            if (!encontrado)
                            {
                                clientes.Add(c);
                                Console.WriteLine("Cliente salvo com sucesso!!!");
                            }
                            else
                            {
                                Console.WriteLine("Não foi possível cadastrar!");
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine(" ---- LISTAR CLIENTES ---- \n");
                        foreach (Cliente clienteCadastrado in clientes)
                        {
                            Console.WriteLine(clienteCadastrado);
                        }
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
