using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula11_interfaces
{
    public class Zebra : IImpressoraDeCodigoDeBarras
    {
        public string Resolucao { get; set; } = "600dpi";
        public string TamEtiq { get; set; } = "15cm x 7cm";
        public string TipoEtiq { get; set; } = "Poliéter";
        public string Cor { get; set; } = "Colorida";
        public string Imprimir(Produto prod){
            return prod.CodBarras;
        }
    }
}