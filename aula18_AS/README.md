AS 2023/1
Programação Orientada a Objetos

Adicionar um Usuario     http://localhost:5000/api/usuario

{
    "nome" : "Natan",
    "senha" : "01278-90",
    "cpf": "123.456.789-01"
}

Adicionar um livro         http://localhost:5000/api/livro

{
    "titulo":"POO",
    "numeroPag":200,
    "codBarras":"123..456.789"
}

Adiconar um autor           http://localhost:5000/api/autor

{
    "nome":"Antonio Paulo",
    "cpf":"123.445.543-00"
}

Adicionar um  emprestimo    http://localhost:5000/api/emprestimo

{
    "usuarioCpf":"123.456.789-00",
    "livroCodBarras":"123.456.000"
}

GetAll usuarios             http://localhost:5000/api/usuario

GetById usuarios            http://localhost:5000/api/usuario/{idUsuario}

Deletar um Emprestimo       http://localhost:5000/api/usuario/{idEmprestimo}

