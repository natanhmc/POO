using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using aula12_entity_frework.Domain.Entities;

namespace aula12_entity_frework.Data
{

    public class DataContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Product> Product {get; set;}
        public DbSet<City> City { get; set; }

        public string DbPath { get; }

        public DataContext()
        {
            string path = Directory.GetCurrentDirectory();
            DbPath = System.IO.Path.Join(path, "TestEF.db");

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}
}
