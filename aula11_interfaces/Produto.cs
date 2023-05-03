using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula11_interfaces
{
    public class Produto
    {
        private static int proximoId = 1;
        public int Id { get;private set; }
        public string CodBarras { get;private set; }
        public decimal Preço { get;private set; }

        public Produto(string cod, decimal preco){
            this.Id = proximoId;
            proximoId++;
            this.CodBarras = cod;
            this.Preço = preco;

        }
    }
}