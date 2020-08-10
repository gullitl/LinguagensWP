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
        public string DataCricao { get; set; }
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
    }
}
