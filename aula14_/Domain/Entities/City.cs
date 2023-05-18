using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula12_entity_frework.Domain.Entities
{
    public class City
    {
        public int Id { get; set; } 
        public string Nome { get; set; }

        public List<Person> People { get; set; }
    }
}