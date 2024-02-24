namespace SmartCollege.API.Models
{
    public class Aluno
    {
        public Aluno()
        {

        }

        public Aluno(int id, string nome, string sobrenome, DateTime dataNascimento, string cpf, string email, string telefone, int cursoId)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            DataNascimento = dataNascimento;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            CursoId = cursoId;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public int? CursoId { get; set; }
        public Curso? Curso { get; set; }
        public IEnumerable<AlunoDisciplina>? AlunosDisciplinas { get; set; }
    }
}