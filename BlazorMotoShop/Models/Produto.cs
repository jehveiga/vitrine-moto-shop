using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace BlazorMotoShop.Models
{
    public class Produto : Entity
    {
        [MinLength(3, ErrorMessage = "O campo {0} precisa ter no mínimo 3 caracteres")]
        [MaxLength(150, ErrorMessage = "O campo {0} precisa ter no máximo 150 caracteres")]
        [Required(ErrorMessage = "O campo {0} não pode ser em branco")]
        public string Nome { get; set; }

        [DisplayName("Descrição")]
        [MinLength(3, ErrorMessage = "O campo {0} precisa ter no mínimo 3 caracteres")]
        [MaxLength(200, ErrorMessage = "O campo {0} precisa ter no máximo 200 caracteres")]
        [Required(ErrorMessage = "O campo {0} não pode ser em branco")]
        public string Descricao { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        [DisplayName("Preço")]
        [Required(ErrorMessage = "O campo {0} não pode ser em branco")]
        [Range(1, 999999, ErrorMessage = "O campo {0} tem que conter valor entre {1} a {2}")]
        public decimal Preco { get; set; }

        [MaxLength(250)]
        [Required(ErrorMessage = "O campo {0} não pode ser em branco")]
        public string ImageUrl { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
