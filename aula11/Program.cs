using aula11.exercicio1;
using aula11.exercicio2;

IPagamento cartao = new CartaoCredito();
IPagamento boleto = new Boleto();

Cliente natan = new Cliente();
Cliente josé = new Cliente();

natan.Comprar(cartao,500.00);
josé.Comprar(boleto,249.87);


IPessoa 