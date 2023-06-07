using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula15_Ap2.Domain.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Enderecos Enderecos { get; set; }
        public double Saldo { get; set; }

    }
}