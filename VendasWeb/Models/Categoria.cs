using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendasWeb.Models
{
    [Table("Categorias")]
    public class Categoria : BaseModel
    {
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
    }
}
