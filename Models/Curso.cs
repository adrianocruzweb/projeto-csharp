using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_csharp.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Aluno { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Aluno.Add(aluno);
        }

        public int ObterQuantidadeAlunosMatriculados()
        {
            return Aluno.Count();
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Aluno.Remove(aluno);
        }

        public void ListarAlunos()
        {
            foreach (var aluno in Aluno)
            {
                Console.WriteLine($"{aluno.NomeCompleto}");
            }
        }

    }
}