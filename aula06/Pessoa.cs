using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_06
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Cidade Cidade { get; set; }

        public List<Endereco> Enderecos { get; set; }

        public Pessoa(int id, string nome, Cidade cidade){
            this.Id = id;
            this.Nome = nome;
            this.Cidade = Cidade;
        }
    }
}