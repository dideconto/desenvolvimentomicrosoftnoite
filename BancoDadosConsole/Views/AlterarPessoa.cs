using BancoDadosConsole.DAL;
using BancoDadosConsole.Models;
using System;

namespace BancoDadosConsole.Views
{
    class AlterarPessoa
    {
        public static void Renderizar()
        {
            Pessoa pessoa = new Pessoa();
            Console.WriteLine(" --- ALTERAR PESSOA --- \n");
            Console.WriteLine("Digite o e-mail da pessoa:");
            pessoa.Email = Console.ReadLine();
            pessoa = PessoaDAO.BuscarPorEmail(pessoa.Email);
            if (pessoa != null)
            {
                Console.Clear();
                Console.WriteLine("Digite o novo nome da pessoa:");
                pessoa.Nome = Console.ReadLine();
                Console.WriteLine("Digite o novo e-mail da pessoa:");
                pessoa.Email = Console.ReadLine();
                PessoaDAO.Alterar(pessoa);
                Console.WriteLine("Pessoa alterada com sucesso!!!");
            }
            else
            {
                Console.WriteLine("Pessoa não encontrada!!!");
            }
        }
    }
}
