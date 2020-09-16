using BancoDadosConsole.DAL;
using BancoDadosConsole.Models;
using System;

namespace BancoDadosConsole.Views
{
    class CadastrarPessoa
    {
        public static void Renderizar()
        {
            PessoaDAO.Cadastrar(
                new Pessoa
                {
                    Nome = "Maria Faria",
                    Email = "maria@maria.com"
                }
            );

            Console.WriteLine("Pessoa cadastrada com sucesso!!!");

            foreach (Pessoa pessoaCadastrada in PessoaDAO.Listar())
            {
                Console.WriteLine(pessoaCadastrada);
            }
        }
    }
}
