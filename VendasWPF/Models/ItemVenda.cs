using System.ComponentModel.DataAnnotations.Schema;

namespace VendasWPF.Models
{
    [Table("ItensVenda")]
    class ItemVenda : BaseModel
    {
        public ItemVenda() => Produto = new Produto();
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
    }
}
