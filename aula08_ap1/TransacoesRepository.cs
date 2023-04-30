using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula08_ap1
{
    public class TransacoesRepository
    {

        private List<TransacoesBancarias> _transacao;

        public TransacoesRepository()
        {
            _transacao = new List<TransacoesBancarias>();
        }

        public void AddTransacoes(TransacoesBancarias transac)
        {
            _transacao.Add(transac);
        }

        public List<TransacoesBancarias> getAll()
        {
            List<TransacoesBancarias> transacoes = new List<TransacoesBancarias>();
            foreach (var transacao in _transacao)
            {
                transacoes.Add(transacao);
            }
            return transacoes;
        }

        public string Saldacao(string cargo)
        {
            return ("Ola " + cargo + ", em que podemos ajuda-lo?");
        }

        public double Pagamento(double Saldo, double valor)
        {
            Saldo -= valor;
            return Saldo;
        }

        public double Saque(double Saldo, double valor)
        {
            Saldo -= valor;
            return Saldo;
        }
        public double Deposito(double Saldo, double valor)
        {
            Saldo += valor;
            return Saldo;
        }
    }
}