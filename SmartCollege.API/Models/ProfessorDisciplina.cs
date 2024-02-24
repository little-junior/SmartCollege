namespace SmartCollege.API.Models
{
    public class ProfessorDisciplina
    {
        public ProfessorDisciplina()
        {
        }

        public ProfessorDisciplina(int professorId, Professor professor, int disciplinaId, Disciplina disciplina)
        {
            ProfessorId = professorId;
            Professor = professor;
            DisciplinaId = disciplinaId;
            Disciplina = disciplina;
        }

        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}