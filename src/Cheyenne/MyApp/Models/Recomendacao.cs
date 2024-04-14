namespace MyApp.Models
{
    public class Recomendacao
    {
        public int Id { get; set; }
        public int PerfilId { get; set; }
        public DateTime DataRecomendacao { get; set; }

        public virtual Perfil Perfil { get; set; }
        public virtual ICollection<RecomendacaoItemTreino> RecomendacaoItensTreino { get; set; }
    }

}
