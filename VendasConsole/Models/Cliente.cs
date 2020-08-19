using System;

namespace VendasConsole.Models
{
    class Cliente
    {
        //Contrutores
        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }
        public Cliente()
        {
            CriadoEm = DateTime.Now;
        }
        //Atributos, propriedades e características
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome} | CPF: {Cpf} | Criado em: {CriadoEm}";
        }

    }
}
