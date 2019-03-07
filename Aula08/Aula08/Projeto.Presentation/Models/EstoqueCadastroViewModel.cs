using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Presentation.Models
{
    public class EstoqueCadastroViewModel
    {        
        [MinLength(3, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(50, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do estoque.")]
        public string Nome { get; set; }
    }    
}