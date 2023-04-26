using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula09_semi_pre.exemplo5
{
    public interface IServicoPagamento
    {

        decimal Saldo { get; }
        void EfetuarPagamento(decimal valor);
        void EstornarPagamento(decimal valor);
            
    }
}