using BancoDadosConsole.DAL;
using BancoDadosConsole.Models;
using System;

namespace BancoDadosConsole.Views
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 15;
            Pessoa pessoa = new Pessoa();
            do
            {
                Console.Clear();
                Console.WriteLine(" ---- PROJETO DE BANCO DE DADOS ---- \n");
                Console.WriteLine("1 - Cadastrar pessoa");
                Console.WriteLine("2 - Listar pessoas");
                Console.WriteLine("3 - Buscar pessoa pelo Id");
                Console.WriteLine("4 - Buscar pessoa pelo e-mail");
                Console.WriteLine("5 - Buscar pessoa única pelo e-mail");
                Console.WriteLine("6 - Filtrar pessoas por parte do nome");
                Console.WriteLine("7 - Remover pessoa");
                Console.WriteLine("8 - Alterar pessoa");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("\nEscolha uma opção:");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        CadastrarPessoa.Renderizar();
                        break;
                    case 2:
                        ListarPessoas.Renderizar(PessoaDAO.Listar());
                        break;
                    case 3:
                        Console.WriteLine(" --- BUSCAR PESSOA PELO ID --- \n");
                        Console.WriteLine("Digite o id da pessoa:");
                        pessoa.PessoaId = Convert.ToInt32(Console.ReadLine());
                        BuscarPessoa.Renderizar(PessoaDAO.BuscarPorId(pessoa.PessoaId));
                        break;
                    case 4:
                        Console.WriteLine(" --- BUSCAR PESSOA PELO E-MAIL --- \n");
                        Console.WriteLine("Digite o e-mail da pessoa:");
                        pessoa.Email = Console.ReadLine();
                        BuscarPessoa.Renderizar(PessoaDAO.BuscarPorEmail(pessoa.Email));
                        break;
                    case 5:
                        try
                        {
                            Console.WriteLine(" --- BUSCAR PESSOA PELO E-MAIL --- \n");
                            Console.WriteLine("Digite o e-mail da pessoa:");
                            pessoa.Email = Console.ReadLine();
                            BuscarPessoa.Renderizar(PessoaDAO.BuscarPorEmailUnico(pessoa.Email));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 6:
                        Console.WriteLine(" --- FILTRAR PESSOAS POR PARTE DO NOME --- \n");
                        Console.WriteLine("Digite parte do nome da pessoa:");
                        pessoa.Nome = Console.ReadLine();
                        ListarPessoas.Renderizar(PessoaDAO.FiltrarPorParteNome(pessoa.Nome));
                        break;
                    case 7:
                        RemoverPessoa.Renderizar();
                        break;
                    case 8:
                        AlterarPessoa.Renderizar();
                        break;
                    case 0:
                        Console.WriteLine("Saindo...\n");
                        break;
                    default:
                        Console.WriteLine(" --- OPÇÃO INVÁLIDA!!! --- \n");
                        break;
                }
                Console.WriteLine("\nAperte uma tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }
    }
}
