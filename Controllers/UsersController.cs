using Microsoft.AspNetCore.Mvc;

namespace CadastroSeguroAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Fununciando");
        }
    }
}