
using System.ComponentModel.DataAnnotations;

namespace VitoriaRestaurante.Models
{
    public class Cliente
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Informe o nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe o restaurante")]
        public string Restaurante { get; set; }
        [Required(ErrorMessage = "Informe o comentário")]
        public string Comentario { get; set; }
    }
}
