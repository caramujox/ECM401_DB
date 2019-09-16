using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;


namespace Alura.Loja.Testes.ConsoleApp
{
    internal class LecionaContext : DbContext
    {
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }

        protected override void  OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=HandsOn3;Trusted_Connection=true;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProfessorDisciplina>().HasKey(pp => new { pp.ProfessorId, pp.DisciplinaId });
            base.OnModelCreating(modelBuilder);

        }
    }
}