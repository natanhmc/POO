using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula04_TDE
{
    public class PessoaRepository
    {
        public static List<Pessoa> people = new List<Pessoa>();

        public List<Pessoa> GetAll(){
           return people;
        }

        public void Attach(string nome, string telefone){
            Pessoa novapessoa = new Pessoa(nome,telefone);
            people.Add(novapessoa);
        }

        public void Delete(int id){
            people.RemoveAll(Pessoa =>Pessoa.Id == id);
        }

        public void Update(int id, string novoNome, string novoTelefone){
            foreach (Pessoa pessoa in people){
                if (pessoa.Id == id){
                    pessoa.Nome = novoNome;
                    pessoa.Telefone = novoTelefone;
                    return;
                }
            }
        }

    }
}