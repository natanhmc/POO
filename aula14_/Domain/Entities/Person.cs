using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula12_entity_frework.Domain.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string phoneNumber { get; set; }
        public int Age { get; set; }
        public City City { get; set; } 
    }
}