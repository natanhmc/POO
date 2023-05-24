using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula15_Ap2.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace aula15_Ap2.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Enderecos> Enderecos { get; set; }
        public DbSet<TransacoesBancarias> TransacoesBancarias { get; set; }
        


        public string DbPath { get; }

        public DataContext()
        {
            string path = Directory.GetCurrentDirectory();
            DbPath = System.IO.Path.Join(path, "Ap2.db");

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
        
    }
}