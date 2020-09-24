using System.ComponentModel.DataAnnotations.Schema;

namespace VendasWPF.Models
{
    [Table("Vendedores")]
    class Vendedor : Pessoa
    {
        public double Salario { get; set; }
    }
}
