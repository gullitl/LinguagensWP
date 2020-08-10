using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Asp.LinguagensWP.Models
{
    public class Linguagem
    {
        [Key]
        public int LinguagemId { get; set; }
        [Required(ErrorMessage ="Campo Nome obrigatório.")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        [DisplayName("Emp. Code")]
        public string EmpCode { get; set; }
        public string Position { get; set; }
        [DisplayName("Office Location")]
        public string OfficeLocation { get; set; }
    }
}
