
using aula12_entity_frework.Data.Repositories;
using aula12_entity_frework.Data;
using aula12_entity_frework.Domain.Entities;

var db = new DataContext();

var personRepository = new PersonRepository(db);


personRepository.Save(new Person(){Name = "teste city", Age = 11, phoneNumber = "98765", City = new City(City.id = 1)});




listPeople();


void listPeople()
{
    Console.WriteLine("listing people");
    var people = personRepository.GetAll();

    foreach (var item in people)
    {
        var mostraCity = item.City == null ? "" : item.City.Nome;
        Console.WriteLine($"Id: {item.Id} | Nome: {item.Name} | Fone: {item.phoneNumber} | Cidade : {mostraCity}");
    }
}