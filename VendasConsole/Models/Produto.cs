using System;

namespace VendasConsole.Models
{
    class Produto
    {
        public Produto()
        {
            CriadoEm = DateTime.Now;
        }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome } | Preço: {Preco} | Quantidade: {Quantidade} | Criado em: {CriadoEm}";
        }
    }
}
