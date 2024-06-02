using Microsoft.CodeAnalysis.Elfie.Serialization;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging.Signing;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShapeApp.Models
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		public DbSet<Treino> Treinos { get; set; }

		public DbSet<Exercicio> Exercicios { get; set; }

		public DbSet<MensagensHome> MensagensHome { get; set; }

		public DbSet<Usuario> Usuarios { get; set; }

		public DbSet<PerfilShape> PerfilShape { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Exercicio>()
				.HasData(new Exercicio
				{
					Id = 1,
					Nome = "Supino Reto",
					Series = 4,
					Repeticoes = 10
				});

			modelBuilder.Entity<Exercicio>()
				.HasData(new Exercicio
				{
					Id = 2,
					Nome = "Elevação lateral",
					Series = 4,
					Repeticoes = 10
				});

			modelBuilder.Entity<Exercicio>()
				.HasData(new Exercicio
				{
					Id = 3,
					Nome = "Remada sentada",
					Series = 4,
					Repeticoes = 10
				});

			modelBuilder.Entity<Exercicio>()
				.HasData(new Exercicio
				{
					Id = 4,
					Nome = "Puxada alta na polia",
					Series = 4,
					Repeticoes = 10
				});

			modelBuilder.Entity<Exercicio>()
				.HasData(new Exercicio
				{
					Id = 5,
					Nome = "Rosca com halteres no banco inclinado",
					Series = 4,
					Repeticoes = 10
				});

			modelBuilder.Entity<Exercicio>()
				.HasData(new Exercicio
				{
					Id = 6,
					Nome = "Elevação da panturrilha",
					Series = 4,
					Repeticoes = 10
				});

			modelBuilder.Entity<Exercicio>()
				.HasData(new Exercicio
				{
					Id = 7,
					Nome = "Flexão de pernas",
					Series = 4,
					Repeticoes = 10
				});

			modelBuilder.Entity<Exercicio>()
				.HasData(new Exercicio
				{
					Id = 8,
					Nome = "Extensão das pernas",
					Series = 4,
					Repeticoes = 10
				});
			modelBuilder.Entity<Exercicio>()
				.HasData(new Exercicio
				{
					Id = 9,
					Nome = "Supino com barra",
					Series = 4,
					Repeticoes = 10
				});

			modelBuilder.Entity<Exercicio>()
				.HasData(new Exercicio
				{
					Id = 10,
					Nome = "Elevações laterais com halteres",
					Series = 4,
					Repeticoes = 10
				});

			modelBuilder.Entity<Exercicio>()
				.HasData(new Exercicio
				{
					Id = 11,
					Nome = "Remada alta",
					Series = 4,
					Repeticoes = 10
				});

			modelBuilder.Entity<Exercicio>()
				.HasData(new Exercicio
				{
					Id = 12,
					Nome = "Rosca com barra",
					Series = 4,
					Repeticoes = 10
				});

			modelBuilder.Entity<Exercicio>()
				.HasData(new Exercicio
				{
					Id = 13,
					Nome = "Rosca martelo",
					Series = 4,
					Repeticoes = 10
				});

			modelBuilder.Entity<Exercicio>()
				.HasData(new Exercicio
				{
					Id = 14,
					Nome = "Tríceps testa",
					Series = 4,
					Repeticoes = 10
				});

			modelBuilder.Entity<Exercicio>()
				.HasData(new Exercicio
				{
					Id = 15,
					Nome = "Tríceps coice",
					Series = 4,
					Repeticoes = 10
				});

			modelBuilder.Entity<Exercicio>()
				.HasData(new Exercicio
				{
					Id = 16,
					Nome = "Tríceps pulley",
					Series = 4,
					Repeticoes = 10
				});

			modelBuilder.Entity<Exercicio>()
				.HasData(new Exercicio
				{
					Id = 17,
					Nome = "Agachamento",
					Series = 4,
					Repeticoes = 10
				});

			modelBuilder.Entity<Exercicio>()
				.HasData(new Exercicio
				{
					Id = 18,
					Nome = "Leg press",
					Series = 4,
					Repeticoes = 10
				});

			modelBuilder.Entity<Usuario>()
				.HasData(new Usuario
				{
					Id = 1,
					Nome = "Maria",
					Senha = BCrypt.Net.BCrypt.HashPassword("123456"),
					Perfil = Perfil.Admin
				});

			modelBuilder.Entity<Usuario>()
				.HasData(new Usuario
				{
					Id = 2,
					Nome = "João",
					Senha = BCrypt.Net.BCrypt.HashPassword("789102"),
					Perfil = Perfil.User
				});

			modelBuilder.Entity<PerfilShape>()
				.HasData(new PerfilShape
				{
					IdPerfil = 1,
					UsuarioId = 1,
					Idade = 25,
					Altura = 1.70m,
					Peso = 70,
					Nivel = Nivel.Intermediario
				});

			modelBuilder.Entity<PerfilShape>()
				.HasData(new PerfilShape
				{
					IdPerfil = 2,
					UsuarioId = 2,
					Idade = 30,
					Altura = 1.80m,
					Peso = 80,
					Nivel = Nivel.Avancado
				});
		}
	}
}
