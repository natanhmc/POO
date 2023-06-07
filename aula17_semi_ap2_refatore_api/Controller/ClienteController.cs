using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula15_Ap2.Data.Repository;
using aula15_Ap2.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace aula17_semi_ap2_refatore_api.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly GerenteCliRepository _repository;

        public ClienteController()
        {
            _repository = new GerenteCliRepository();

        }
        [HttpGet]
        public IEnumerable<Cliente> Get(){
            return _repository.GetAll();
        }

        [HttpPost]
        public void Post(Cliente item){

            _repository.Save(item);
            
        }

        [HttpPut]
        public void Put(Cliente item){
            _repository.Update(item);
        }

        [HttpGet("{id}")]

        public Cliente Get(int id){
            return _repository.GetById(id);
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return Ok( new {
                statusCode=200,
                message = "Cliente excluído com sucesso !!"
            });
        }


    }
}