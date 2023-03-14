using aula02_classe_objeto_construtor_metodos;

Livro livroBD = new Livro(111,"292929", "banco de dados", 240);
Console.WriteLine(livroBD.Id + "-" + livroBD.Isbn + "-"+ livroBD.Titulo);

Show("digite algo:");
var retorno = Console.ReadLine();

Show("o usuario retornou " + retorno);

Show("digite um numero:");
double num1 =Convert.ToDouble(Console.ReadLine());

Show("digite outro numero:");
double num2 = Convert.ToDouble(Console.ReadLine());

Calculadora calculadoraNatan = new Calculadora();
var result = calculadoraNatan.Somar(num1,num2);

Show(" a soma é " + result);

void Show(string msg)
{
Console.WriteLine(msg);
}