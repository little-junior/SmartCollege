namespace SmartCollege.API.Models
{
    public class CursoDisciplina
    {
        public CursoDisciplina()
        {
        }

        public CursoDisciplina(int cursoId, int disciplinaId)
        {
            CursoId = cursoId;
            DisciplinaId = disciplinaId;
        }

        public int CursoId { get; set; }
        public Curso Curso { get; set; }
        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}