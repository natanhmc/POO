

namespace aula18_AS.Domain.Entities
{
    public class Autor : Entity
    {
        public string Nome { get; set; }    
        public string CPF { get; set; }
        public List<AutoresLivro> LivrosAutores { get; set; }

    }
}