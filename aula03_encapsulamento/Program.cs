using aula03_encapsulamento;

Livro livro = new Livro(123,"1233543-1234","POO");
Livro livro1= new Livro(123,"1233543-1234","Banco de Dados");
Livro livro2 = new Livro(123,"1233543-1234","IA");
Livro livro3 = new Livro(123,"1233543-1234","C#");


List<Livro> listaLivro = new List<Livro>();

listaLivro.Add(livro);
listaLivro.Add(livro1);
listaLivro.Add(livro2);
listaLivro.Add(livro3);


LivroRepository.books();

LivroRepository repository = new LivroRepository();

repository.Adicionar(livro);
repository.Adicionar(livro1);
repository.Adicionar(livro2);


for (int i = 0; i < LivroRepository.books.Count; i++)
{
    if(LivroRepository.books[i].Id==2){
        Mostrar(LivroRepository.books[i].Titulo);
    }
}

foreach (var item in LivroRepository.books)
{
    if(item.Id==2){
        Mostrar(item.Titulo);
    }
}
Mostrar(LivroRepository.books.Find(livro => livro.Id==2).Titulo);











void Mostrar(string msg){
    Console.WriteLine(msg);
}

