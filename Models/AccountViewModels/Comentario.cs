using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VitoriaRestaurante.Models.AccountViewModels
{
    public class Comentario
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Informe o nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe o restaurante")]
        public string Restaurante { get; set; }
        [Required(ErrorMessage = "Informe o comentário")]
        public string Opiniao { get; set; }
    }
}
