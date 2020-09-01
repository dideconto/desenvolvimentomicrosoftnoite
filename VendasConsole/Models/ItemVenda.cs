using System;

namespace VendasConsole.Models
{
    class ItemVenda
    {
        public ItemVenda()
        {
            CriadoEm = DateTime.Now;
            Produto = new Produto();
        }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
