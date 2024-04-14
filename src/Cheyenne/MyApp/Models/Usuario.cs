namespace MyApp.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Admin { get; set; } = false;

        // Relação um-para-um com Perfil
        public virtual Perfil Perfil { get; set; }
    }
}
