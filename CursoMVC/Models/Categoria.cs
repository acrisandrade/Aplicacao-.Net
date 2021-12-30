using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        //DataAnotation, Utilizado para exibir a informacao de um a forma mais amigavel.
        [Display(Name = "Descrição")]
        [Required (ErrorMessage ="O Campo descrição é Obrigatório")]
        public string Descricao { get; set; }

      
    }
}
