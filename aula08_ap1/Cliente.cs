using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula08_ap1
{
    public class Cliente
    {
        private static int proximoId = 1;
        public double Saldo { get; set; }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public Enderecos Enderecos { get; set; }

        public Cliente(string nome, Enderecos enderecos, double saldo)
        {
            Saldo = saldo;
            Nome = nome;
            Enderecos = enderecos;
            Id = proximoId;
            proximoId++;
        }
    }
}