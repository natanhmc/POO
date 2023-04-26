using aula09_semi_pre.exemplo1;
using aula09_semi_pre.exemplo2;
using aula09_semi_pre.exemplo3;
using aula09_semi_pre.exemplo4;
using aula09_semi_pre.exemplo5;

// -------------------------------------------------exemplo 1
Gato gato = new Gato();
Cachorro cachorro = new Cachorro();
Papagaio papagaio = new Papagaio();

gato.EmitirSom();
cachorro.EmitirSom();
papagaio.EmitirSom();

// ------------------------------------------------- exemplo 2

FormatadorMinusculo maior = new FormatadorMinusculo();
FormatadorMinusculo menor = new FormatadorMinusculo();
FormatadorInverso osrevni = new FormatadorInverso();

maior.FormatarTexto("Eu sou maior!!");
menor.FormatarTexto("EU SOU MENOR!!");
osrevni.FormatarTexto("!!oirartnoc oa uos ue");

// -------------------------------------------------exemplo 3

Dono dono1 = new Dono("Pedro");
Dono dono2 = new Dono("Marcos");

Gatto gato1 = new Gatto("Miau",dono1);
Cachorroo dog = new Cachorroo("Toby",dono2);

// ------------------------------------------------exemplo 4

Calculadora calculo = new Calculadora();

calculo.Somar(11,7654);
calculo.Diminuir(123,456);
calculo.Dividir(25,6);
calculo.Multiplicar(78,9);

// -----------------------------------------------exemplo 5

PagamentoBoleto boleto = new PagamentoBoleto(100.00m);
PagamentoCartao cartao = new PagamentoCartao(980.50m);
PagamentoPaypal paypal = new PagamentoPaypal(184.35m);

boleto.EfetuarPagamento(45.05m);
boleto.EstornarPagamento(20.00m);
cartao.EfetuarPagamento(10.00m);
cartao.EstornarPagamento(50.50m);
paypal.EfetuarPagamento(38.78m);
paypal.EstornarPagamento(84.89m);



