using System.ComponentModel.DataAnnotations.Schema;

namespace VendasWPF.Models
{
    [Table("Clientes")]
    class Cliente : Pessoa
    {
        public string Email { get; set; }
    }
}
