﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShapeApp.Models;

#nullable disable

namespace ShapeApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExercicioTreino", b =>
                {
                    b.Property<int>("ExerciciosId")
                        .HasColumnType("int");

                    b.Property<int>("TreinosId")
                        .HasColumnType("int");

                    b.HasKey("ExerciciosId", "TreinosId");

                    b.HasIndex("TreinosId");

                    b.ToTable("ExercicioTreino");
                });

            modelBuilder.Entity("ShapeApp.Models.Exercicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Repeticoes")
                        .HasColumnType("int");

                    b.Property<int>("Series")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Exercicios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Supino Reto",
                            Repeticoes = 10,
                            Series = 4
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Elevação lateral",
                            Repeticoes = 10,
                            Series = 4
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Remada sentada",
                            Repeticoes = 10,
                            Series = 4
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Puxada alta na polia",
                            Repeticoes = 10,
                            Series = 4
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Rosca com halteres no banco inclinado",
                            Repeticoes = 10,
                            Series = 4
                        },
                        new
                        {
                            Id = 6,
                            Nome = "Elevação da panturrilha",
                            Repeticoes = 10,
                            Series = 4
                        },
                        new
                        {
                            Id = 7,
                            Nome = "Flexão de pernas",
                            Repeticoes = 10,
                            Series = 4
                        },
                        new
                        {
                            Id = 8,
                            Nome = "Extensão das pernas",
                            Repeticoes = 10,
                            Series = 4
                        },
                        new
                        {
                            Id = 9,
                            Nome = "Supino com barra",
                            Repeticoes = 10,
                            Series = 4
                        },
                        new
                        {
                            Id = 10,
                            Nome = "Elevações laterais com halteres",
                            Repeticoes = 10,
                            Series = 4
                        },
                        new
                        {
                            Id = 11,
                            Nome = "Remada alta",
                            Repeticoes = 10,
                            Series = 4
                        },
                        new
                        {
                            Id = 12,
                            Nome = "Rosca com barra",
                            Repeticoes = 10,
                            Series = 4
                        },
                        new
                        {
                            Id = 13,
                            Nome = "Rosca martelo",
                            Repeticoes = 10,
                            Series = 4
                        },
                        new
                        {
                            Id = 14,
                            Nome = "Tríceps testa",
                            Repeticoes = 10,
                            Series = 4
                        },
                        new
                        {
                            Id = 15,
                            Nome = "Tríceps coice",
                            Repeticoes = 10,
                            Series = 4
                        },
                        new
                        {
                            Id = 16,
                            Nome = "Tríceps pulley",
                            Repeticoes = 10,
                            Series = 4
                        },
                        new
                        {
                            Id = 17,
                            Nome = "Agachamento",
                            Repeticoes = 10,
                            Series = 4
                        },
                        new
                        {
                            Id = 18,
                            Nome = "Leg press",
                            Repeticoes = 10,
                            Series = 4
                        });
                });

            modelBuilder.Entity("ShapeApp.Models.MensagensHome", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Mensagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TituloMensagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MensagensHome");
                });

            modelBuilder.Entity("ShapeApp.Models.PerfilShape", b =>
                {
                    b.Property<int>("IdPerfil")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPerfil"));

                    b.Property<decimal>("Altura")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<int>("Nivel")
                        .HasColumnType("int");

                    b.Property<decimal>("Peso")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("IdPerfil");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Perfil");

                    b.HasData(
                        new
                        {
                            IdPerfil = 1,
                            Altura = 1.70m,
                            Idade = 25,
                            Nivel = 1,
                            Peso = 70m,
                            UsuarioId = 1
                        },
                        new
                        {
                            IdPerfil = 2,
                            Altura = 1.80m,
                            Idade = 30,
                            Nivel = 2,
                            Peso = 80m,
                            UsuarioId = 2
                        });
                });

            modelBuilder.Entity("ShapeApp.Models.Treino", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("DuracaoRecomendada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Objetivo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Treinos");
                });

            modelBuilder.Entity("ShapeApp.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Perfil")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuários");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Maria",
                            Perfil = 0,
                            Senha = "$2a$11$ucsOXNMde1xWnHNnTuN/ou75Bp/lhDuI.xqEsZGfTwS547GZ7z8He"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "João",
                            Perfil = 1,
                            Senha = "$2a$11$PRJ8tEi94u9M3F8EfWj/rOaYEufDPJXXcoNgIZVyAC.6arVSQvQhu"
                        });
                });

            modelBuilder.Entity("ExercicioTreino", b =>
                {
                    b.HasOne("ShapeApp.Models.Exercicio", null)
                        .WithMany()
                        .HasForeignKey("ExerciciosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShapeApp.Models.Treino", null)
                        .WithMany()
                        .HasForeignKey("TreinosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShapeApp.Models.PerfilShape", b =>
                {
                    b.HasOne("ShapeApp.Models.Usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
