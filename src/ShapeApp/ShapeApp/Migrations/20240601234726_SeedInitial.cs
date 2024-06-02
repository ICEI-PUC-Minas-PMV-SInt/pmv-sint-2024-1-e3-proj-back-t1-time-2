using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShapeApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Exercicios",
                columns: new[] { "Id", "Nome", "Repeticoes", "Series" },
                values: new object[,]
                {
                    { 1, "Supino Reto", 10, 4 },
                    { 2, "Elevação lateral", 10, 4 },
                    { 3, "Remada sentada", 10, 4 },
                    { 4, "Puxada alta na polia", 10, 4 },
                    { 5, "Rosca com halteres no banco inclinado", 10, 4 },
                    { 6, "Elevação da panturrilha", 10, 4 },
                    { 7, "Flexão de pernas", 10, 4 },
                    { 8, "Extensão das pernas", 10, 4 },
                    { 9, "Supino com barra", 10, 4 },
                    { 10, "Elevações laterais com halteres", 10, 4 },
                    { 11, "Remada alta", 10, 4 },
                    { 12, "Rosca com barra", 10, 4 },
                    { 13, "Rosca martelo", 10, 4 },
                    { 14, "Tríceps testa", 10, 4 },
                    { 15, "Tríceps coice", 10, 4 },
                    { 16, "Tríceps pulley", 10, 4 },
                    { 17, "Agachamento", 10, 4 },
                    { 18, "Leg press", 10, 4 }
                });

            migrationBuilder.InsertData(
                table: "Usuários",
                columns: new[] { "Id", "Nome", "Perfil", "Senha" },
                values: new object[,]
                {
                    { 1, "Maria", 0, "$2a$11$ucsOXNMde1xWnHNnTuN/ou75Bp/lhDuI.xqEsZGfTwS547GZ7z8He" },
                    { 2, "João", 1, "$2a$11$PRJ8tEi94u9M3F8EfWj/rOaYEufDPJXXcoNgIZVyAC.6arVSQvQhu" }
                });

            migrationBuilder.InsertData(
                table: "Perfil",
                columns: new[] { "IdPerfil", "Altura", "Idade", "Nivel", "Peso", "UsuarioId" },
                values: new object[,]
                {
                    { 1, 1.70m, 25, 1, 70m, 1 },
                    { 2, 1.80m, 30, 2, 80m, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercicios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exercicios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Exercicios",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Exercicios",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Exercicios",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Exercicios",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Exercicios",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Exercicios",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Exercicios",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Exercicios",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Exercicios",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Exercicios",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Exercicios",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Exercicios",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Exercicios",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Exercicios",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Exercicios",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Exercicios",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Usuários",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Usuários",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
