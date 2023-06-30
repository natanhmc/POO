using aula18_AS.Data.Context;
using aula18_AS.Domain.Entities;
using aula18_AS.Domain.Interfaces.RepositoryInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace aula18_AS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AutorController : ControllerBase
    {
        private readonly IAutorRepository _repository;

        public AutorController(IAutorRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public IEnumerable<Autor> Get(){
            return _repository.GetAll();
        }

        [HttpPost]
        public IActionResult Post(Autor item){
            _repository.Save(item);
            return Ok(item);
        }

        [HttpPut]
        public IActionResult Put(Autor item){
            _repository.Update(item);
            return Ok(item);
        }

        [HttpGet("{id}")]
        public Autor Get(int id){
            return _repository.GetById(id);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return Ok( new {
                statusCode=200,
                message = "Autor excluído com sucesso !!"
            });
        }
        
    }
}