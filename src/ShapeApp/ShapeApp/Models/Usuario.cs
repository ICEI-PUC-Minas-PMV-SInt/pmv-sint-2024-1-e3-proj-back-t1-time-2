using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShapeApp.Models
{
    [Table("Usuários")]
    public class Usuario
    {
        [Key]
        public int   Id { get; set; }

        [Required(ErrorMessage = "Obridatório informar o nome")] 
        public String   Nome { get; set; }

        [Required(ErrorMessage = "Obridatório informar a senha")]

        [DataType(DataType.Password)]
        public String   Senha { get; set; }

        [Required(ErrorMessage = "Obridatório informar a senha")]
        public Perfil   Perfil { get; set; }

    }
   public enum Perfil 
    {
        Admin,
        User
    }
}
