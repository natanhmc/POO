using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula03_encapsulamento
{
    public class LivroRepository
    {

        public static List<Livro> books = new List<Livro>();

        public List<Livro>GetAll(){
            return books;
        }

        public Livro GetById(int id){
            return books.Find(li => li.Id == id);
        }
        public void Adicionar(Livro livro){
            books.Add(livro);
        }

        public void Deletar(int id){

        }
    }
}