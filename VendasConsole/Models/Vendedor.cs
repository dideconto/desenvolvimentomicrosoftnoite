using System;

namespace VendasConsole.Models
{
    class Vendedor
    {
        public Vendedor()
        {
            CriadoEm = DateTime.Now;
        }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome} | CPF: {Cpf} | Criado em: {CriadoEm}";
        }
    }
}
