using BancoDadosConsole.DAL;
using BancoDadosConsole.Models;
using System;

namespace BancoDadosConsole.Views
{
    class RemoverPessoa
    {
        public static void Renderizar()
        {
            Pessoa pessoa = new Pessoa();
            Console.WriteLine(" --- REMOVER PESSOA --- \n");
            Console.WriteLine("Digite o e-mail da pessoa:");
            pessoa.Email = Console.ReadLine();
            pessoa = PessoaDAO.BuscarPorEmail(pessoa.Email);
            if (pessoa != null)
            {
                PessoaDAO.Remover(pessoa);
                Console.WriteLine("Pessoa removida com sucesso!!!");
            }
            else
            {
                Console.WriteLine("Pessoa não encontrada!!!");
            }
        }
    }
}
