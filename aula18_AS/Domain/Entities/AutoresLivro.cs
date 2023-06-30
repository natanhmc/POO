namespace aula18_AS.Domain.Entities
{
    public class AutoresLivro : Entity
    {
        public Autor Autores { get; set; }
        public string AutorCpf { get; set; }
        public Livro Livros { get; set; }
        public string LivroCodBarras { get; set; }
    }
}