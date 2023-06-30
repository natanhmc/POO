using aula18_AS.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using aula18_AS.Domain.Interfaces.RepositoryInterfaces;
using AutoMapper;
using aula18_AS.Domain.DTOs;

namespace aula18_AS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuariosRepository _repository;
        
        public UsuarioController(IUsuariosRepository usuario){
            _repository = usuario;
        }
        [HttpGet]
        public IEnumerable<Usuario> Get(){
            return _repository.GetAll();
            
        }


        [HttpPost]
        public IActionResult Post(Usuario item){
            _repository.Save(item);
            return Ok(item);
        }

        [HttpPut]
        public IActionResult Put(Usuario item){
            _repository.Update(item);
            return Ok(item);
        }

        [HttpGet("{id}")]
        public Usuario Get(int id){
            return _repository.GetById(id);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return Ok( new {
                statusCode=200,
                message = "Usuário excluído com sucesso !!"
            });
        }

        

    }
}