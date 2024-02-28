using SmartCollege.API.Models.Enums;

namespace SmartCollege.API.Models
{
    public class Curso
    {
        public Curso()
        {
        }

        public Curso(int id, string nome, Modalidades modalidade, Periodos periodo)
        {
            Id = id;
            Nome = nome;
            Modalidade = modalidade;
            Periodo = periodo;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public Modalidades Modalidade { get; set; }
        public Periodos Periodo { get; set; }
        public IEnumerable<CursoDisciplina> CursosDisciplinas { get; set; }
        public IEnumerable<Aluno> Alunos { get; set; }
    }
}