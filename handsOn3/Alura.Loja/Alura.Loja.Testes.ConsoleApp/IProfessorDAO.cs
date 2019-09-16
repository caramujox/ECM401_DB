using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    interface IProfessorDAO
    {
        void Adicionar(Professor professor);
        void Remover(Professor professor);
        void Atualizar(Professor professor);
        IList<Professor> Professores();
    }
}
