using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula15_Ap2.Domain.Entities
{
    public class Gerente
    {
        public int id = 1;
        public string  Nome  = "Natan Hugentobler";
        public int Senha = 1234;  
        public bool VerificaSenha(int senhaDigitada){
            return senhaDigitada == Senha;
        }
    }
}