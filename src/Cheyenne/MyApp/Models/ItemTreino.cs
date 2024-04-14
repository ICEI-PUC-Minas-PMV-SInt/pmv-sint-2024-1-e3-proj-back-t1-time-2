namespace MyApp.Models
{

    public class ItemTreino
    {
        public int Id { get; set; }
        public int TreinoId { get; set; }
        public int ExercicioId { get; set; }
        public int Repeticoes { get; set; }
        public int Series { get; set; }

        public virtual Treino Treino { get; set; }
        public virtual Exercicio Exercicio { get; set; }
        public virtual ICollection<RecomendacaoItemTreino> RecomendacaoItensTreino { get; set; }
    }
}
