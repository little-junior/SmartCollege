using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartCollege.API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Modalidade = table.Column<int>(type: "INTEGER", nullable: false),
                    Periodo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Sobrenome = table.Column<string>(type: "TEXT", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Cpf = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Sobrenome = table.Column<string>(type: "TEXT", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Cpf = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Telefone = table.Column<string>(type: "TEXT", nullable: false),
                    CursoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Semestre = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alunos_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Disciplinas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Sala = table.Column<string>(type: "TEXT", nullable: false),
                    ProfessorId = table.Column<int>(type: "INTEGER", nullable: false),
                    Periodo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplinas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disciplinas_Professores_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlunosDisciplinas",
                columns: table => new
                {
                    AlunoId = table.Column<int>(type: "INTEGER", nullable: false),
                    DisciplinaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunosDisciplinas", x => new { x.AlunoId, x.DisciplinaId });
                    table.ForeignKey(
                        name: "FK_AlunosDisciplinas_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlunosDisciplinas_Disciplinas_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CursosDisciplinas",
                columns: table => new
                {
                    CursoId = table.Column<int>(type: "INTEGER", nullable: false),
                    DisciplinaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursosDisciplinas", x => new { x.CursoId, x.DisciplinaId });
                    table.ForeignKey(
                        name: "FK_CursosDisciplinas_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CursosDisciplinas_Disciplinas_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "Id", "Modalidade", "Nome", "Periodo" },
                values: new object[] { 1, 1, "Engenharia", 1 });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "Id", "Modalidade", "Nome", "Periodo" },
                values: new object[] { 2, 1, "Administração", 2 });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "Id", "Modalidade", "Nome", "Periodo" },
                values: new object[] { 3, 1, "Direito", 3 });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "Id", "Modalidade", "Nome", "Periodo" },
                values: new object[] { 4, 1, "Medicina", 1 });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "Id", "Modalidade", "Nome", "Periodo" },
                values: new object[] { 5, 1, "Ciência da Computação", 3 });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "Id", "Cpf", "DataNascimento", "Email", "Nome", "Sobrenome" },
                values: new object[] { 1, "123.456.789-01", new DateTime(1970, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "lauro@email.com", "Lauro", "Silva" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "Id", "Cpf", "DataNascimento", "Email", "Nome", "Sobrenome" },
                values: new object[] { 2, "987.654.321-09", new DateTime(1985, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "roberto@email.com", "Roberto", "Almeida" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "Id", "Cpf", "DataNascimento", "Email", "Nome", "Sobrenome" },
                values: new object[] { 3, "456.789.012-34", new DateTime(1980, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "ronaldo@email.com", "Ronaldo", "Souza" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "Id", "Cpf", "DataNascimento", "Email", "Nome", "Sobrenome" },
                values: new object[] { 4, "654.321.098-76", new DateTime(1975, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "rodrigo@email.com", "Rodrigo", "Oliveira" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "Id", "Cpf", "DataNascimento", "Email", "Nome", "Sobrenome" },
                values: new object[] { 5, "789.012.345-67", new DateTime(1990, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "alexandre@email.com", "Alexandre", "Ferreira" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Cpf", "CursoId", "DataNascimento", "Email", "Nome", "Semestre", "Sobrenome", "Telefone" },
                values: new object[] { 1, "111.222.333-44", 1, new DateTime(2000, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "joao@email.com", "João", 1, "Silva", "9999-8888" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Cpf", "CursoId", "DataNascimento", "Email", "Nome", "Semestre", "Sobrenome", "Telefone" },
                values: new object[] { 2, "222.333.444-55", 2, new DateTime(1999, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "maria@email.com", "Maria", 2, "Santos", "7777-6666" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Cpf", "CursoId", "DataNascimento", "Email", "Nome", "Semestre", "Sobrenome", "Telefone" },
                values: new object[] { 3, "333.444.555-66", 3, new DateTime(2001, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "pedro@email.com", "Pedro", 1, "Oliveira", "5555-4444" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Cpf", "CursoId", "DataNascimento", "Email", "Nome", "Semestre", "Sobrenome", "Telefone" },
                values: new object[] { 4, "444.555.666-77", 4, new DateTime(2002, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ana@email.com", "Ana", 2, "Pereira", "3333-2222" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Cpf", "CursoId", "DataNascimento", "Email", "Nome", "Semestre", "Sobrenome", "Telefone" },
                values: new object[] { 5, "555.666.777-88", 5, new DateTime(2003, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "lucas@email.com", "Lucas", 1, "Costa", "1111-0000" });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "Nome", "Periodo", "ProfessorId", "Sala" },
                values: new object[] { 1, "Cálculo I", 1, 1, "Sala A" });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "Nome", "Periodo", "ProfessorId", "Sala" },
                values: new object[] { 2, "Retórica e Humanidades", 2, 2, "Sala B" });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "Nome", "Periodo", "ProfessorId", "Sala" },
                values: new object[] { 3, "Programação Orientada a Objetos", 3, 3, "Sala C" });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "Nome", "Periodo", "ProfessorId", "Sala" },
                values: new object[] { 4, "Biologia Celular", 1, 4, "Sala D" });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "Nome", "Periodo", "ProfessorId", "Sala" },
                values: new object[] { 5, "Química I", 2, 5, "Sala E" });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 1, 5 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 3, 2 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 4, 4 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 5, 1 });

            migrationBuilder.InsertData(
                table: "CursosDisciplinas",
                columns: new[] { "CursoId", "DisciplinaId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "CursosDisciplinas",
                columns: new[] { "CursoId", "DisciplinaId" },
                values: new object[] { 1, 5 });

            migrationBuilder.InsertData(
                table: "CursosDisciplinas",
                columns: new[] { "CursoId", "DisciplinaId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "CursosDisciplinas",
                columns: new[] { "CursoId", "DisciplinaId" },
                values: new object[] { 3, 2 });

            migrationBuilder.InsertData(
                table: "CursosDisciplinas",
                columns: new[] { "CursoId", "DisciplinaId" },
                values: new object[] { 4, 4 });

            migrationBuilder.InsertData(
                table: "CursosDisciplinas",
                columns: new[] { "CursoId", "DisciplinaId" },
                values: new object[] { 5, 1 });

            migrationBuilder.InsertData(
                table: "CursosDisciplinas",
                columns: new[] { "CursoId", "DisciplinaId" },
                values: new object[] { 5, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_CursoId",
                table: "Alunos",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_AlunosDisciplinas_DisciplinaId",
                table: "AlunosDisciplinas",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_CursosDisciplinas_DisciplinaId",
                table: "CursosDisciplinas",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_ProfessorId",
                table: "Disciplinas",
                column: "ProfessorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlunosDisciplinas");

            migrationBuilder.DropTable(
                name: "CursosDisciplinas");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Disciplinas");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Professores");
        }
    }
}
