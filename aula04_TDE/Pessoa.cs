using System;


namespace aula04_TDE
{
    public class Pessoa
    {
        private static int proximoId = 0;
        public int Id { get;}
        public Guid Codigo { get; set; }
        public string Nome{get; set;}
        public string Telefone {get; set;}

        public Pessoa( string nome, string telefone){
            Id = Interlocked.Increment(ref proximoId);
            this.Nome = nome;
            this.Telefone = telefone;
            Codigo = System.Guid.NewGuid();
        }
         
    }
}