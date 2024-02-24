using Microsoft.AspNetCore.Mvc;
using SmartCollege.API.Models;

namespace SmartCollege.API
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly List<Aluno> _alunos = new List<Aluno>()
        {
            new Aluno()
            {
                Id = 1,
                Nome = "Pedro",
                Sobrenome = "Jose",
                Cpf = "11111111111",
                Email = "pedrojose@gmail.com",
                Telefone = "3123123213213"
            },
            new Aluno()
            {
                Id = 2,
                Nome = "Carlos",
                Sobrenome = "Almeira",
                Cpf = "22222222222",
                Email = "carlosalmeira@gmail.com",
                Telefone = "534534534534534"
            }
        };

        [HttpGet]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(_alunos);
        }

        [HttpGet("byId")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetById(int id)
        {
            var aluno = _alunos.FirstOrDefault(a => a.Id == id);

            if (aluno == null)
                return BadRequest("Aluno not found.");

            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, [FromBody] Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete (int id)
        {
            return Ok();
        }
    }
}