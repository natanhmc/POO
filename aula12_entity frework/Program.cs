
using aula12_entity_frework.Data.Repositories;
using aula12_entity_frework.Data;
using aula12_entity_frework.Domain.Entities;

var db = new DataContext();

var personRepository = new PersonRepository(db);

// Console.WriteLine("Inserting a new person using repository person");
// var person = new Person() { Id = 4, Name = "Vanessa", phoneNumber ="55987987987987" };
// personRepository.Save(person);

listPeople();

var personFind = personRepository.GetById(4);

Console.WriteLine($"\nId: {personFind.Id} | Nome: {personFind.Name} | Fone: {personFind.phoneNumber}");

// Console.WriteLine("Inserting a new product");
// var prod = new Product(){Id=100, Description="Garrafa alcool gel"};

// Console.WriteLine("delete person id 3...");
// personRepository.Delete(3);

// listPeople();

var people = new Person() { Id = 5, Name = "teste de update",Age = 32,  phoneNumber ="55987987987987" };
personRepository.Update(people);


listPeople();


void listPeople()
{
    Console.WriteLine("listing people");
    var people = personRepository.GetAll();

    foreach (var item in people)
    {
        Console.WriteLine($"Id: {item.Id} | Nome: {item.Name} | Fone: {item.phoneNumber}");
    }
}