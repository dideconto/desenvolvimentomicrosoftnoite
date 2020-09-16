using BancoDadosConsole.Models;
using System;
using System.Collections.Generic;

namespace BancoDadosConsole.Views
{
    class ListarPessoas
    {
        public static void Renderizar(List<Pessoa> pessoas)
        {
            Console.WriteLine("\n --- LISTAR PESSOAS --- \n");
            foreach (Pessoa pessoaCadastrado in pessoas)
            {
                Console.WriteLine(pessoaCadastrado);
            }
        }
    }
}
