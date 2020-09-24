using System.ComponentModel.DataAnnotations.Schema;

namespace VendasWPF.Models
{
    [Table("Produtos")]
    class Produto : BaseModel
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
    }
}
