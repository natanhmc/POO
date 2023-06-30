using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula18_AS.Domain.Entities;
using aula18_AS.Domain.Interfaces.RepositoryInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace aula18_AS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LivroController : ControllerBase
    {
        private readonly ILivroRepository _repository;
        
        public LivroController(ILivroRepository livro)
        {
            _repository = livro;
        }

        [HttpGet]
        public IEnumerable<Livro> Get(){
            return _repository.GetAll();
        }

        [HttpPost]
        public IActionResult Post(Livro item){
            _repository.Save(item);
            return Ok(item);
        }

        [HttpPut]
        public IActionResult Put(Livro item){
            _repository.Update(item);
            return Ok(item);
        }

        [HttpGet("{id}")]
        public Livro Get(int id){
            return _repository.GetById(id);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return Ok( new {
                statusCode=200,
                message = "Livro excluído com sucesso !!"
            });
        }
    }
}