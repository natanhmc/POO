using Microsoft.AspNetCore.Mvc;

namespace aula16_apis.Controllers;

[ApiController]
[Route("[controller]")]
public class PessoasController : ControllerBase
{
    [HttpGet("lista")]
    public IEnumerable<string> GetPessoas(){
        var pessoas = new List<string>{
            "Joao",
            "Natan",
            "fulano"

        };
        return pessoas;
        
    }

}
