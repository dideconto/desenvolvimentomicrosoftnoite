using System;
using VendasConsole.DAL;
using VendasConsole.Models;
using VendasConsole.Utils;

namespace VendasConsole.Views
{
    class CadastrarVendedor
    {
        public static void Renderizar()
        {
            Vendedor v = new Vendedor();
            Console.WriteLine(" ---- CADASTRAR VENDEDOR ---- \n");
            Console.WriteLine("Digite o nome do vendedor:");
            v.Nome = Console.ReadLine();
            Console.WriteLine("Digite o cpf do vendedor:");
            v.Cpf = Console.ReadLine();
            if (Validacao.ValidarCpf(v.Cpf))
            {
                if (VendedorDAO.Cadastrar(v))
                {
                    Console.WriteLine("Vendedor cadastrado com sucesso!!!");
                }
                else
                {
                    Console.WriteLine("Esse vendedor já existe!!!");
                }
            }
            else
            {
                Console.WriteLine("CPF inválido!!!");
            }
        }
    }
}
