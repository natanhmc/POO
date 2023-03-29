using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula04_TDE
{
    public class Pessoa
    {
        private static int proximoId = 0;
        public int Id { get;}
        public string Nome{get; set;}
        public string Telefone {get; set;}

        public Pessoa( string nome, string telefone){
            Id = System.Threading.Interlocked.Increment(ref proximoId);
            this.Nome = nome;
            this.Telefone = telefone;
        }
    }
}