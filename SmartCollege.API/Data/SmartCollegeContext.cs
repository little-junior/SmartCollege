using Microsoft.EntityFrameworkCore;
using SmartCollege.API.Models;
using SmartCollege.API.Models.Enums;

namespace SmartCollege.API.Data
{
    public class SmartCollegeContext : DbContext
    {
        public SmartCollegeContext(DbContextOptions<SmartCollegeContext> options) : base(options)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<AlunoDisciplina> AlunosDisciplinas { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<CursoDisciplina> CursosDisciplinas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<AlunoDisciplina>()
                .HasKey(AD => new { AD.AlunoId, AD.DisciplinaId });

            modelBuilder
                .Entity<CursoDisciplina>()
                .HasKey(CD => new { CD.CursoId, CD.DisciplinaId });

            modelBuilder.Entity<Professor>()
                .HasData(new List<Professor>()
                {
                    new Professor(1, "Lauro", "Silva", new DateTime(1970, 5, 10), "123.456.789-01", "lauro@email.com"),
                    new Professor(2, "Roberto", "Almeida", new DateTime(1985, 8, 15), "987.654.321-09", "roberto@email.com"),
                    new Professor(3, "Ronaldo", "Souza", new DateTime(1980, 3, 25), "456.789.012-34", "ronaldo@email.com"),
                    new Professor(4, "Rodrigo", "Oliveira", new DateTime(1975, 12, 8), "654.321.098-76", "rodrigo@email.com"),
                    new Professor(5, "Alexandre", "Ferreira", new DateTime(1990, 6, 20), "789.012.345-67", "alexandre@email.com")
                });

            modelBuilder.Entity<Curso>()
                .HasData(new List<Curso>()
                {
                    new Curso(1, "Engenharia", Modalidades.Presencial, Periodos.Manha),
                    new Curso(2, "Administração", Modalidades.Presencial, Periodos.Tarde),
                    new Curso(3, "Direito", Modalidades.Presencial, Periodos.Noite),
                    new Curso(4, "Medicina", Modalidades.Presencial, Periodos.Manha),
                    new Curso(5, "Ciência da Computação", Modalidades.Presencial, Periodos.Noite)
                });


            modelBuilder.Entity<Aluno>()
                .HasData(new List<Aluno>()
                {
                    new Aluno(1, "João", "Silva", new DateTime(2000, 2, 15), "111.222.333-44", "joao@email.com", "9999-8888", 1, 1),
                    new Aluno(2, "Maria", "Santos", new DateTime(1999, 4, 20), "222.333.444-55", "maria@email.com", "7777-6666", 2, 2),
                    new Aluno(3, "Pedro", "Oliveira", new DateTime(2001, 10, 5), "333.444.555-66", "pedro@email.com", "5555-4444", 1, 3),
                    new Aluno(4, "Ana", "Pereira", new DateTime(2002, 8, 30), "444.555.666-77", "ana@email.com", "3333-2222", 2, 4),
                    new Aluno(5, "Lucas", "Costa", new DateTime(2003, 5, 12), "555.666.777-88", "lucas@email.com", "1111-0000", 1, 5)
            });

            modelBuilder.Entity<Disciplina>()
                .HasData(new List<Disciplina>()
                {
                    new Disciplina(1, "Cálculo I", "Sala A", 1, Periodos.Manha),
                    new Disciplina(2, "Retórica e Humanidades", "Sala B", 2, Periodos.Tarde),
                    new Disciplina(3, "Programação Orientada a Objetos", "Sala C", 3, Periodos.Noite),
                    new Disciplina(4, "Biologia Celular", "Sala D", 4, Periodos.Manha),
                    new Disciplina(5, "Química I", "Sala E", 5, Periodos.Tarde)
                });

            modelBuilder.Entity<AlunoDisciplina>()
                .HasData(new List<AlunoDisciplina>() {
                    new AlunoDisciplina() {AlunoId = 1, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 1, DisciplinaId = 5 },
                    new AlunoDisciplina() {AlunoId = 2, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 3, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 4, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 5, DisciplinaId = 1 },
                });

            modelBuilder.Entity<CursoDisciplina>()
                .HasData(new List<CursoDisciplina>(){
                    new CursoDisciplina() {CursoId = 1, DisciplinaId = 1 },
                    new CursoDisciplina() {CursoId = 1, DisciplinaId = 5 },
                    new CursoDisciplina() {CursoId = 2, DisciplinaId = 2 },
                    new CursoDisciplina() {CursoId = 3, DisciplinaId = 2 },
                    new CursoDisciplina() {CursoId = 4, DisciplinaId = 4 },
                    new CursoDisciplina() {CursoId = 5, DisciplinaId = 1 },
                    new CursoDisciplina() {CursoId = 5, DisciplinaId = 3 },
                });
        }
    }
}