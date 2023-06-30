

namespace aula18_AS.Domain.Entities
{
    public class Emprestimo : Entity
    {
        public Usuario Usuario { get; set; }
        public string UsuarioCpf { get; set; }
        public Livro Livro{ get; set; }
        public string LivroCodBarras { get; set; }
    }
}