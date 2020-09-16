using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BancoDadosConsole.Models
{
    [Table("Pessoas")]
    class Pessoa
    {
        public Pessoa()
        {
            CriadoEm = DateTime.Now;
        }

        [Key]
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString() => $"Nome: {Nome} | E-mail: {Email} | Criado em: {CriadoEm}";

    }
}
