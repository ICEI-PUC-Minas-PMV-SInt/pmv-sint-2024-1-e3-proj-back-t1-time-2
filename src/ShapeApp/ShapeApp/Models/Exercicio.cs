using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShapeApp.Models
{
    [Table("Exercicios")]
    public class Exercicio
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o número de series!")]
        public int Series{ get; set; }

        [Required(ErrorMessage = "Obrigatório informar o número de repetições!")]
        [Display(Name = "Repetições")]
        public int Repeticoes { get; set; }
    }
}