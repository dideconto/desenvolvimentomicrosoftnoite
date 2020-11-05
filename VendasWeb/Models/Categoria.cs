using System.ComponentModel.DataAnnotations.Schema;

namespace VendasWeb.Models
{
    [Table("Categorias")]
    public class Categoria : BaseModel
    {
        public string Nome { get; set; }
    }
}
