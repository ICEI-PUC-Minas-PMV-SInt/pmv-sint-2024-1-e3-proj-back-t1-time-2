namespace MyApp.Models
{
    public class Perfil
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public string Nivel { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<Treino> Treinos { get; set; }
        public virtual ICollection<Recomendacao> Recomendacoes { get; set; }
    }
}
