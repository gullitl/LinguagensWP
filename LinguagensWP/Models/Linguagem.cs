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
        [DisplayName("Emp. Code")]
        public string EmpCode { get; set; }
        public string Position { get; set; }
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
    }
}
