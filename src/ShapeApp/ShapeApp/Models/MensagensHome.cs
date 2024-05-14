using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShapeApp.Models
{
    [Table("MensagensHome")]
    public class MensagensHome
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Título da mensagem é obrigatório")]
        public string TituloMensagem { get; set; }

        [Required(ErrorMessage = "É obrigatório informar uma mensagem a ser cadastrada")]
        public string Mensagem { get; set; }
    }
}
