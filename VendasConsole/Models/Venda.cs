using System;
using System.Collections.Generic;

namespace VendasConsole.Models
{
    class Venda
    {
        public Venda()
        {
            CriadoEm = DateTime.Now;
            Cliente = new Cliente();
            Vendedor = new Vendedor();
            Itens = new List<ItemVenda>();
        }
        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }
        public List<ItemVenda> Itens { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
