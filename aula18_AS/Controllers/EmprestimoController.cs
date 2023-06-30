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
    public class EmprestimoController : ControllerBase
    {
        private readonly IEmprestimoRepository _repository;
        
        public EmprestimoController(IEmprestimoRepository emprestimo){
            _repository = emprestimo;
        }
        [HttpGet]
        public IEnumerable<Emprestimo> Get(){
            return _repository.GetAll();
        }

        [HttpPost]
        public IActionResult Post(Emprestimo item){
            _repository.Save(item);
            return Ok(item);
        }

        [HttpPut]
        public IActionResult Put(Emprestimo item){
            _repository.Update(item);
            return Ok(item);
        }

        [HttpGet("{id}")]
        public Emprestimo Get(int id){
            return _repository.GetById(id);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return Ok( new {
                statusCode=200,
                message = "Emprestimo excluído com sucesso !!"
            });
        }
        
    }
}