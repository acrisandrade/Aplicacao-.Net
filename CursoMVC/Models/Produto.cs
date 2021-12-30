using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }
        //DataAnotation, Utilizado para exibir a informacao de um a forma mais amigavel.
        [Display(Name ="Descrição")]
        [Required(ErrorMessage = "O Campo descrição é Obrigatório")]
        public string Descricao { get; set; }
        //solicita valores de 1 a 10
        [Range(1,10, ErrorMessage ="Valorfora da faixa")]
        public int Quantidade { get; set; }

        public int CategoriaId { get; set; }

        public Categoria categoria { get; set; }
    }
}
