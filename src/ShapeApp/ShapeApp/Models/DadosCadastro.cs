using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShapeApp.Models
{
    public class DadosCadastro
    {

        public Usuario Usuario { get; set; }

        public PerfilShape PerfilShape { get; set; }

    }
}
