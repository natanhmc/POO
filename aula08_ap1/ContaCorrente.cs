using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula08_ap1
{
    public interface ContaCorrente
    {
        public Cliente cliente { get;protected set; }

        public string Saldacao();
        
    }
}