using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VitoriaRestaurante.Models.AccountViewModels
{
    public class CommentViewModel
    {
        [Required]
        public string Usuario { get; set; }

        [Required]
        public string Dica { get; set; }
    }
}
