using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShapeApp.Models
{
    [Table("Perfil")]
    public class PerfilShape
    {

        [Key]
        public int IdPerfil { get; set; }

        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario usuario { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a idade")]
        [Range(0, 150, ErrorMessage = "A idade não pode ser negativa.")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a altura")]
        [Range(0, 3, ErrorMessage = "A altura deve estar entre 0 e 3 metros.")]
        public decimal Altura { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o peso")]
        [Range(0, 1000, ErrorMessage = "O peso deve estar entre 0 e 1000 quilos.")]
        public decimal Peso { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nivel")]
        public Nivel Nivel { get; set; }

    }

    public enum Nivel
    {
        Iniciante,
        Intermediario,
        Avancado
    }
}
