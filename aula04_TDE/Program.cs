using aula04_TDE;
using System;

    PessoaRepository repository = new PessoaRepository();
    var op = 1;
    while (op != 0)
    {
        Show("informe a opçao desejada:\n 1-adicionar pessoa.\n 2-deletar pessoa.\n 3-atualizar pessoa.\n 4-mostrar todas pessoas.\n 5-sair");
        op = Convert.ToInt32(Console.ReadLine());
        switch (op){
            case 1:
                Show("informe o nome:");
                string nome = Console.ReadLine();
                Show("informe o telefone:");
                string telefone = Console.ReadLine();
                repository.Attach(nome,telefone);
                Show("Pessoa adicionada com sucesso!!");
            break;
            case 2:
                Show("Informe o id para deletar:");
                int id = Convert.ToInt32(Console.ReadLine());
                repository.Delete(id);
                Show("Pessoa deletada com sucesso!!");
            break;
            case 3:
                Show("informe o id a ser atualizado:");
                int id_novo = Convert.ToInt32(Console.ReadLine());
                Show("informe o novo nome:");
                string novo_nome = Console.ReadLine();
                Show("informe o novo numero de telefone:");
                string novo_telefone = Console.ReadLine();
                repository.Update(id_novo,novo_nome,novo_telefone);
                Show("Pessoa atualizada com sucesso!!");
            break;
            case 4:
                var list =  repository.GetAll();
                list.ForEach(x => Console.WriteLine($"Id: {x.Id}, Nome: {x.Nome}, Telefone: {x.Telefone}, Codigo: {x.Codigo}"));

            break;
            case 5:
                op = 0;
            break;
        }
        
    }
    
    void Show(string msg){
        Console.WriteLine(msg);
    }
