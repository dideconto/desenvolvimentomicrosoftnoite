using System.ComponentModel.DataAnnotations.Schema;

namespace VendasWeb.Models
{
    [Table("Produtos")]
    public class Produto : BaseModel
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
    }
}
