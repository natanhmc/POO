

namespace aula18_AS.Domain.Entities
{
    public class Livro : Entity
    {
        public string Titulo { get; set; }
        public int NumeroPag { get; set; }
        public string CodBarras { get; set; }

        public List<AutoresLivro> LivrosAutores { get; set; }
        public List<Emprestimo> Emprestimos { get; set; }
    }
}