using aula02_exercicios;
using System;
int o = 5;
while (o > 0){
    Mostrar("informe o numero no exercicio: 1, 2, 3 ou 0 para sair.");
    o = Convert.ToInt32(Console.ReadLine());
    switch (o){
        case 1:
            Calculadora calculadoraNatan = new Calculadora();

            int i = 3;
            while(i > 0){

                Mostrar("informe um numero:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Mostrar("informe outro numero:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Mostrar("gostaria de fazer alguma conta matematica:\n 1 para '+'\n 2 para '-'\n 3 para  '/'\n 4 para '*' : \n 0 para sair.");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op){
                    case 1:
                        
                        var soma = calculadoraNatan.Somar(num1,num2);
                        Mostrar("a soma é "+ soma);
                    break;
                    case 2:
                        var subtrair = calculadoraNatan.Subtrair(num1,num2);
                        Mostrar("a subtracao é "+ subtrair);
                    break;
                    case 3:
                        var divisao = calculadoraNatan.Dividir(num1,num2);
                        Mostrar("a divisao é "+ divisao);
                    break;
                    case 4:
                        var multiplica = calculadoraNatan.Multiplicar(num1,num2);
                        Mostrar("a multiplicacao é "+ multiplica);
                    break;
                    case 0:
                        i=0;
                    break;
                }    
            }

        break;
        case 2:
            Mostrar("informe seu nome: 'ele nao pode ser nulo'");
            string nome = Console.ReadLine();
            Mostrar("informe sua idade:");
            int idade = Convert.ToInt32(Console.ReadLine());

            Pessoa pessoa = new Pessoa();
            pessoa.Nome = nome;
            pessoa.Idade = idade;

            Mostrar(pessoa.Apresentar());
            
        break;
        case 3:

            ContaBancaria ContaNatan = new ContaBancaria(123,15999);
            ContaNatan.Depositar(1000);
            ContaNatan.Estrato();
            ContaNatan.Sacar(9876);
            ContaNatan.Estrato();


        break;
        case 0:
            o = 0;
        break;    
    }
}



void Mostrar(string msg){
    Console.WriteLine(msg);
}

