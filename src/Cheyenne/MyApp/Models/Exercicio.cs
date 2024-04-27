namespace MyApp.Models
{
    public class Exercicio
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Classificacao { get; set; }
        public string GrupoMuscular { get; set; }
        public string Mecanica { get; set; }

        public virtual ICollection<ItemTreino> ItensTreino { get; set; }
    }

}
