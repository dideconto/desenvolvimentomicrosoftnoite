using System.ComponentModel.DataAnnotations.Schema;

namespace VendasWeb.Models
{
    public class ItemVenda : BaseModel
    {
        public ItemVenda() => Produto = new Produto();

        [ForeignKey("ProdutoId")]
        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public string CarrinhoId { get; set; }
    }
}
