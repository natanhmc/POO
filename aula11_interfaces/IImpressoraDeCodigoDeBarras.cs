using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula11_interfaces
{
    public interface IImpressoraDeCodigoDeBarras
    {
        public string Resolucao { get; }  
        public string TamEtiq { get;} 
        public string TipoEtiq { get;}
        public string Cor { get;}
        public string Imprimir(Produto _produto);
    }
}