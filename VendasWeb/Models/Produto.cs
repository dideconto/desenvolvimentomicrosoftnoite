using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendasWeb.Models
{
    [Table("Produtos")]
    public class Produto : BaseModel
    {
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(5, ErrorMessage = "Mínimo 5 caracteres!")]
        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Range(1, 200, ErrorMessage = "Valores entre 1 e 200!")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public double Preco { get; set; }
        public string Imagem { get; set; }
    }
}
