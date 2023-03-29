
namespace aula03_encapsulamento
{
    public class Livro
    {
        
        public int Id {get;private set;}
        public string Isbn { get;private set; }
        public string Titulo { get; set; }
        public double Preco { get; set; }

        public Livro(int id, string isbn, string titulo, double preco = 0){
            this.Id = id;
            this.Isbn = isbn;
            this.Titulo = titulo;
            this.Preco = preco;
        }
       

    }
}