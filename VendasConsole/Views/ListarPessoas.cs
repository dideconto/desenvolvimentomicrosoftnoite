using System;
using System.Collections.Generic;

namespace VendasConsole.Views
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
