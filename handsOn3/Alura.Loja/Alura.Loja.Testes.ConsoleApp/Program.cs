using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new LecionaContext())
            {
                //var disciplinaDB = new Disciplina();
                //disciplinaDB.CodigoDisciplina = "ECM401";
                //disciplinaDB.Nome = "DB";
                //disciplinaDB.Id = 1;

                //var disciplinaControle = new Disciplina();
                //disciplinaControle.CodigoDisciplina = "ECM301";
                //disciplinaControle.Nome = "Controle";
                //disciplinaControle.Id = 2;



                var professores = contexto.Professores.ToList();
                foreach( var professor in professores)
                {
                    Console.WriteLine(professor);
                }
            }

        }

        private static void GravarUsandoAdoNet()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var repo = new ProdutoDAO())
            {
                repo.Adicionar(p);
            }
        }

        private static void GravarUsandoEntity()
        {
            Professor professor = new Professor();
            professor.Id = 1;
            professor.Nome = "Victor";
            professor.cpf = "123.456.789-0";
            
            using (var contexto =  new ProfessorDAOEntity())
            {
                contexto.Adicionar(professor);
            }
        }

        private static void RecuperaProfessores()
        {
            using (var repo = new ProfessorDAOEntity())
            {
                IList<Professor> professores = repo.Professores();
                foreach(var professor in professores)
                {
                    Console.WriteLine("Id: " + professor.Id + " Nome:" + professor.Nome + " CPF:" + professor.cpf);
                }
            }
        }

        private static void DeletarProfessores()
        {
            using (var repo = new ProfessorDAOEntity())
            {
                IList<Professor> professores = repo.Professores();
                Console.WriteLine("Foram encontrados {0} professores", professores.Count);


            }
        }

        private static void AlterarProfessor()
        {
            using (var repo = new ProfessorDAOEntity())
            {
                Professor professor = repo.Professores().First();
                professor.Nome = "Vitão";
                repo.Atualizar(professor);
            }
            RecuperaProfessores();
        }
    }

}
