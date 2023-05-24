using aula15_Ap2;
using aula15_Ap2.Data;
using aula15_Ap2.Data.Repository;
using aula15_Ap2.Domain.Entities;

public class Program
{
    static void Main(string[] args)
    {
        var db = new DataContext();
        var endeRepo = new GerenteEndRepository(db);
        var cliRepo = new GerenteCliRepository(db);
        var tranRepo = new TransacoesRepository(db);

        Gerente gerente = new Gerente();

        while (true)
        {
            Mostrar("Digite a senha:");
            int senha = LerNumero();

            if (gerente.VerificaSenha(senha))
            {
                var oper = 99;
                while (oper != 0)
                {

                    Mostrar("Informe a operação desejada:\n 1-Para crud de clientes.\n 2-Para fazer transações bancarias.\n 3-Para crud de enderecos.\n 4-Para sair.");
                    oper = LerNumero();
                    switch (oper)
                    {
                        case 1:

                            var _func = 1;
                            do
                            {
                                Mostrar("Digite: \n 1 para adicionar. \n 2 para mostrar todos. \n 3 para mostrar apenas um. \n 4 para fazer um update. \n 5 para deletar. \n 6 para sair.");
                                int i = LerNumero();
                                switch (i)
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

                                        var enderecos = new Enderecos();
                                        enderecos.Rua = end1;
                                        enderecos.Bairro = end2;
                                        var client = new Cliente();
                                        client.Nome = cli;
                                        client.Saldo = saldo;
                                        client.Enderecos = enderecos;

                                        cliRepo.Save(client);
                                        endeRepo.Save(enderecos);

                                        break;
                                    case 2:
                                        var list = cliRepo.GetAll();
                                        foreach (var item in list)
                                        {
                                            Mostrar($"Id: {item.Id} | Nome: {item.Nome} | Saldo: {item.Saldo} |");
                                        }
                                        break;
                                    case 3:
                                        Mostrar("informe o id");
                                        int _id = LerNumero();
                                        var clien = cliRepo.GetById(_id);
                                        Mostrar($"Id: {clien.Id} | Nome: {clien.Nome} | Saldo: {clien.Saldo}");
                                        // |                           Rua: { clien.Enderecos.Rua} | Bairro: { clien.Enderecos.Bairro};
                                        break;
                                    case 4:

                                        break;
                                    case 5:
                                        Mostrar("informe o id");
                                        int _id_ = LerNumero();
                                        cliRepo.Delete(_id_);
                                        Mostrar("Cliente deletado !!");

                                        break;
                                    case 6:
                                        // Mostrar("Obrigado por fazer negócios com a gente!!");

                                        _func = 0;
                                        break;
                                    default:
                                        i = 6;
                                        break;

                                }
                            } while (_func != 0);
                            break;
                        case 2:

                            var func = 4;
                            while (func != 0)
                            {
                                Mostrar("Informe o ID do cliente: ");
                                var _cli = cliRepo.GetById(LerNumero());
                                if (_cli == null)
                                {
                                    Mostrar("Cliente com o ID especificado não encontrado.");
                                    continue;
                                }
                                Mostrar("Qual transações você quer fazer:\n1-Para Sacar.\n2-Para Depositar.\n3-Para Sair.");
                                func = LerNumero();
                                switch (func)
                                {
                                    case 1:
                                        Mostrar("informe valor a sacar:");
                                        var valor1 = LerDouble();
                                        tranRepo.Saque(_cli.Id, valor1);
                                        Mostrar("Seu saldo agora é de " + _cli.Saldo);
                                        var tran = new TransacoesBancarias();
                                        tran.cliente = _cli;
                                        tran.Operacao = "Saque";
                                        tran.Valor = valor1;
                                        tranRepo.Save(tran);
                                        break;
                                    case 2:
                                        Mostrar("informe valor a depositar:");
                                        var valor2 = LerDouble();
                                        tranRepo.Deposito(_cli.Id, valor2);
                                        Mostrar("Seu saldo agora é de " + _cli.Saldo);
                                        var tran2 = new TransacoesBancarias();
                                        tran2.cliente = _cli;
                                        tran2.Operacao = "Deposito";
                                        tran2.Valor = valor2;
                                        tranRepo.Save(tran2);
                                        break;
                                    case 3:
                                        func = 0;
                                        break;
                                    default:
                                        func = 3;
                                        break;
                                }

                            };

                            break;
                        case 3:
                            int index = 99;
                            do
                            {
                                Mostrar("Informe a opçõa desejada:\n 1-Para mostrar todos os enderecos.\n 2-Para mostrar apenas um endereço.\n 3-Para fazer update.\n 4-Para deletar.\n 5-Para adicionar.\n 6-Para sair");
                                int _i = LerNumero();
                                switch (_i)
                                {
                                    case 1:
                                        foreach (var item in endeRepo.GetAll())
                                        {
                                            Mostrar($"Id: {item.Id} |  Rua: {item.Rua} | Bairro: {item.Bairro}");
                                        }
                                        break;
                                    case 2:
                                        Mostrar("informe o id");
                                        var ende = endeRepo.GetById(LerNumero()); ;
                                        Mostrar($"Id: {ende.Id} |Rua: {ende.Rua} | Bairro: {ende.Bairro}");
                                        break;
                                    case 3:
                                        Mostrar("Obrigado por utilizar nossos serviços!");
                                        index = 0;
                                        break;
                                    case 4:
                                        Mostrar("informe o id");
                                        endeRepo.Delete(LerNumero());
                                        Mostrar("Endereco deletado !!");
                                        break;
                                    case 5:
                                        Mostrar("Informe o nome da rua:");
                                        var end1 = LerString();
                                        Mostrar("Informe o bairro:");
                                        var end2 = LerString();

                                        var _endereco = new Enderecos();
                                        _endereco.Rua = end1;
                                        _endereco.Bairro = end2;

                                        endeRepo.Save(_endereco);

                                        break;
                                    case 6:
                                        // Mostrar("Obrigado por fazer negócios com a gente!!");

                                        index = 0;

                                        break;
                                    default:
                                        index = 6;
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

            }
            else
            {
                Mostrar("Senha incorreta! Tente novamente.");
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





