namespace SmartCollege.API.Models
{
    public class Professor
    {
        public Professor()
        {
        }

        public Professor(int id, string nome, string sobrenome, DateOnly dataNascimento, string cpf, string email)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            DataNascimento = dataNascimento;
            Cpf = cpf;
            Email = email;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateOnly DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public IEnumerable<Disciplina> Disciplinas { get; set; }
    }
}