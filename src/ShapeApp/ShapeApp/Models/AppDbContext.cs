﻿using Microsoft.EntityFrameworkCore;

namespace ShapeApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Treino> Treinos { get; set; }

        public DbSet<Exercicio> Exercicios { get; set;}
    }
}