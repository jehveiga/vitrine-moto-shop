using System.ComponentModel.DataAnnotations;

namespace BlazorMotoShop.Models
{
    public class Categoria : Entity
    {
        [MaxLength(150, ErrorMessage = "O campo {0} precisa ter no máximo 150 caracteres")]
        [Required(ErrorMessage = "O campo {0} não pode ser em branco")]
        public string Nome { get; set; }
    }
}
