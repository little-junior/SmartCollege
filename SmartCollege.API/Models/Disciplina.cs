using SmartCollege.API.Models.Enums;

namespace SmartCollege.API.Models
{
    public class Disciplina
    {
        public Disciplina()
        {

        }

        public Disciplina(int id, string nome, string sala, int professorId, Periodos periodo)
        {
            Id = id;
            Nome = nome;
            Sala = sala;
            ProfessorId = professorId;
            Periodo = periodo;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sala { get; set; }
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
        public Periodos Periodo { get; set; }
        public IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; }
        public IEnumerable<CursoDisciplina> CursosDisciplinas { get; set; }
    }
}