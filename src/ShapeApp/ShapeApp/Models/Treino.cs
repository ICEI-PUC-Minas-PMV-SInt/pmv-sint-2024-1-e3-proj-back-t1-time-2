using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShapeApp.Models
{
    [Table("Treinos")]
    public class Treino
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Data de Início")]
        public DateTime DataInicio { get; set; }
        
        public string Objetivo { get; set; }

        [Display(Name = "Duração de Treino")]
        public string DuracaoRecomendada { get; set; }

        public List<Exercicio> Exercicios { get; set; } = new();
    }
}
