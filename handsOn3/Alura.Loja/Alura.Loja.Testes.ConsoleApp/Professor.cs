using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class Professor 
    {
        public int Id { get; internal set; }
        public string Nome { get; internal set; }
        public string cpf { get; internal set; }
        public IList<ProfessorDisciplina> ProfessoresDisciplinas { get; set; }

        public override string ToString()
        {
            return "Professor: " + this.Nome;
        }
    }
}
