using aula11_interfaces;

public class Program
{
    private static List<IImpressoraDeCodigoDeBarras> listImpressoras = new List<IImpressoraDeCodigoDeBarras>();
    
    static void Main(string[] args)
    {
        IImpressoraDeCodigoDeBarras elgin = new Elgin();
        IImpressoraDeCodigoDeBarras zebra = new Zebra();

        listImpressoras.Add(elgin);
        listImpressoras.Add(zebra);

        Mostrar("informe o codigo de barras: ");
        string codB = AtribuirString();
        Mostrar("Informe o valor do produto");
        decimal val = AtribuiDecimal();
        Produto prod = new Produto(codB, val);

        foreach (var impressoras  in listImpressoras)
        {
            Mostrar ("codigo              "+ impressoras.Imprimir(prod));
            Mostrar("Resolução:           "+ impressoras.Resolucao);
            Mostrar("Tamanho da etiqueta: "+ impressoras.TamEtiq);
            Mostrar("Tipo da etiqueta:    "+ impressoras.TipoEtiq);
            Mostrar("Cor:                 "+ impressoras.Cor);
            Mostrar("\n");
        }


        void Mostrar(string msg)
        {
            Console.WriteLine(msg);
        }

        string AtribuirString(){

            string input = Console.ReadLine();

            return input;
        }

        decimal AtribuiDecimal()
        {
            string input = Console.ReadLine();
            decimal valor;

            if (!decimal.TryParse(input, out valor))
            {
                Mostrar("Entrada inválida! Por favor, digite um número valido.");
                
            }

            return valor;
        }

    }
}
