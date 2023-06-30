

namespace aula18_AS.Domain.Entities
{
    public class Usuario : Entity
    {
        public string Nome { get; set; }
        public string Senha { get; set; }   
        public string CPF { get; set; }

        public List<Emprestimo> Emprestimo { get; set; }
    }
}