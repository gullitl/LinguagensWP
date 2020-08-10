using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Asp.LinguagensWP.Models
{
    public class Linguagem
    {
        [Key]
        public int LinguagemId { get; set; }
        [Required(ErrorMessage ="Campo Nome obrigatório.")]
        [DisplayName("Nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo Autor obrigatório.")]
        [DisplayName("Autor")]
        public string Autor { get; set; }
        [DisplayName("Data Criação")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DataCricao { get; set; }
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
    }
}
