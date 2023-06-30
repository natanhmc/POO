using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula18_AS.Domain.DTOs
{
    public class LivroDTO
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int NumeroPag { get; set; }
    }
}