using System.Collections.Generic;
using VendasConsole.Models;

namespace VendasConsole.DAL
{
    class VendaDAO
    {
        private static List<Venda> vendas = new List<Venda>();
        private static List<Venda> aux = new List<Venda>();
        public static void Cadastrar(Venda venda) => vendas.Add(venda);
        public static List<Venda> Listar() => vendas;
        public static List<Venda> ListarPorCliente(string cpf)
        {
            aux.Clear();
            foreach (Venda vendaCadastrada in Listar())
            {
                if (vendaCadastrada.Cliente.Cpf == cpf)
                {
                    aux.Add(vendaCadastrada);
                }
            }
            return aux;
        }
    }
}
