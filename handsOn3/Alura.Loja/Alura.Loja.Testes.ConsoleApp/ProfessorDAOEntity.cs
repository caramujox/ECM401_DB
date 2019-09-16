using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class ProfessorDAOEntity : IProfessorDAO, IDisposable
    {

        private LecionaContext contexto;

        public ProfessorDAOEntity()
        {
            this.contexto = new LecionaContext();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }


        public void Adicionar(Professor professor)
        {
            contexto.Professores.Add(professor);
            contexto.SaveChanges();
        }

        public void Atualizar(Professor professor)
        {
            contexto.Professores.Update(professor);
            contexto.SaveChanges();
        }

        public IList<Professor> Professores()
        {
            return contexto.Professores.ToList();
        }

        public void Remover(Professor professor)
        {
            contexto.Professores.Remove(professor);
        }
    }
}
