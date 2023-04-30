using aula08_ap1;

public class Program
{
    static void Main(string[] args)
    {
        var repoEnd = new EnderecosRepository();
        var repoCli = new ClienteRepository();
        var repoTran = new TransacoesRepository();

        var oper = 99;
        while (oper != 0)
        {
            Mostrar("Informe a operação desejada:\n 1-Para adicionar um cliente.\n 2-Para fazer transações bancarias.\n 3-Se você é membro de nossa equipe.\n 4-Para sair.");
            oper = LerNumero();
            switch (oper)
            {
                case 1:
                    Mostrar("Informe o nome do cliente:");
                    var cli = LerString();
                    Mostrar("Informe o nome da rua:");
                    var end1 = LerString();
                    Mostrar("Informe o bairro:");
                    var end2 = LerString();
                    Mostrar("Informe o Saldo:");
                    var saldo = LerDouble();

                    Enderecos enderecos = new Enderecos(end1, end2);
                    Cliente cliente = new Cliente(cli, enderecos, saldo);
                    TransacoesBancarias conta = new TransacoesBancarias(cliente);

                    repoCli.Add(cliente);
                    repoEnd.Add(enderecos);
                    repoTran.AddTransacoes(conta);

                    Mostrar(conta.Saldacao());
                    break;

                case 2:

                    var func = 1;
                    do
                    {
                        Mostrar("Informe o ID do cliente: ");
                        Cliente _cli = repoCli.GetClienteById(LerNumero());
                        if (_cli == null)
                        {
                            Mostrar("Cliente com o ID especificado não encontrado.");
                            continue;
                        }
                        Mostrar("Qual transações você quer fazer:\n1-Para Pagamento.\n2-Para Sacar.\n3-Para Depositar.\n4-Para Sair.");
                        func = LerNumero();
                        switch (func)
                        {
                            case 1:
                                Mostrar("informe valor a pagar:");
                                var valor = LerDouble();
                                _cli.Saldo = repoTran.Pagamento(_cli.Saldo, valor);
                                Mostrar("Seu saldo agora é de " + _cli.Saldo);
                                break;
                            case 2:
                                Mostrar("informe valor a sacar:");
                                var valor1 = LerDouble();
                                _cli.Saldo = repoTran.Saque(_cli.Saldo, valor1);
                                Mostrar("Seu saldo agora é de " + _cli.Saldo);
                                break;
                            case 3:
                                Mostrar("informe valor a depositar:");
                                var valor2 = LerDouble();
                                _cli.Saldo = repoTran.Saque(_cli.Saldo, valor2);
                                Mostrar("Seu saldo agora é de " + _cli.Saldo);
                                break;
                            case 4:
                                func = 0;
                                break;
                        }

                    } while (func != 0);

                    break;
                case 3:
                    Mostrar("Informe seu cargo:");
                    var cargo = LerString();
                    Mostrar(repoTran.Saldacao(cargo));
                    int index = 99;
                    do
                    {
                        Mostrar("Olá " + cargo + ", informe a opçõa desejada:\n 1-Para mostrar todos os clientes.\n 2-Para excluir um cliente.\n 3-Para sair.");
                        int i = LerNumero();
                        switch (i)
                        {
                            case 1:
                                Mostrar(repoCli.getAll());
                                break;
                            case 2:
                                Mostrar("informe o id do cliente");
                                int id = LerNumero();
                                repoCli.Remove(id);
                                break;
                            case 3:
                                Mostrar("Obrigado por utilizar nossos serviços!");
                                index = 0;
                                break;

                        }
                    } while (index != 0);

                    break;
                case 4:
                    Mostrar("Obrigado por fazer negócios com a gente!!");
                    oper = 0;
                    break;
            }

        }






        void Mostrar(string msg)
        {
            Console.WriteLine(msg);
        }

        int LerNumero()
        {
            string input = Console.ReadLine();
            int numero;

            if (!int.TryParse(input, out numero))
            {
                Mostrar("Entrada inválida! Por favor, digite um número inteiro.");
                return LerNumero();
            }

            return numero;
        }
        
        string LerString()
        {
            string input = Console.ReadLine();

            return input;
        }

        double LerDouble()
        {
            string input = Console.ReadLine();
            double numero;

            if (!double.TryParse(input, out numero))
            {
                Mostrar("Entrada inválida! Por favor, digite um número valido.");
                return LerNumero();
            }

            return numero;
        }

    }


}


