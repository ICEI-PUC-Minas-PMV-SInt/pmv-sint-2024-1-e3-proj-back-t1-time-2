namespace MyApp.Models
{
    public class Treino
    {
        public int Id { get; set; }
        public int PerfilId { get; set; }
        public DateTime DataInicio { get; set; }

        public virtual Perfil Perfil { get; set; }
        public virtual ICollection<ItemTreino> ItensTreino { get; set; }
    }
}
