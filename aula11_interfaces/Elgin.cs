using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula11_interfaces
{
    public class Elgin : IImpressoraDeCodigoDeBarras
    {
        public string Resolucao { get; set; } = "300dpi";
        public string TamEtiq { get; set; } = "10cm x 5cm";
        public string TipoEtiq { get; set; } = "Papel Adesivo";
        public string Cor { get; set; } = "Preto e Branco";
        public string Imprimir(Produto prod){
            return prod.CodBarras;
        }
    }
}