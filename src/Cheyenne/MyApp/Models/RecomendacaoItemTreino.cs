namespace MyApp.Models
{
    public class RecomendacaoItemTreino
    {
        public int Id { get; set; }
        public int RecomendacaoId { get; set; }
        public int ItemTreinoId { get; set; }

        public virtual Recomendacao Recomendacao { get; set; }
        public virtual ItemTreino ItemTreino { get; set; }
    }
}
