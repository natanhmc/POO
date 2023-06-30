using aula18_AS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace aula18_AS.Data.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Usuario> DbSetUsuario { get; set; }
        public DbSet<Livro> DbSetLivro { get; set; }
        public DbSet<Autor> DbSetAutor { get; set; }
        public DbSet<Emprestimo> DbSetEmprestimo { get; set; }
        public DbSet<AutoresLivro> DbSetAutorLivro { get; set;}
        protected string DbPath { get; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            string path = Directory.GetCurrentDirectory();
            DbPath = System.IO.Path.Join(path, "aula18_AS.db");
        } 
    } 
}
