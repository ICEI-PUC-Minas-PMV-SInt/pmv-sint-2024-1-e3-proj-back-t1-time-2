using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace MyApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Perfil> Perfis { get; set; }
        public DbSet<Treino> Treinos { get; set; }
        public DbSet<Recomendacao> Recomendacoes { get; set; }
        public DbSet<ItemTreino> ItensTreino { get; set; }
        public DbSet<Exercicio> Exercicios { get; set; }
        public DbSet<RecomendacaoItemTreino> RecomendacaoItensTreino { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the relationships here if necessary
        }
    }
}
