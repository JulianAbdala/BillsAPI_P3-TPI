using Microsoft.AspNetCore.Mvc;
using Practicaweb.API.Services;

namespace Practicaweb.API.Controllers
{
    [ApiController]
    [Route("api/Users")]
    public class userController : ControllerBase
    {   //Inyeccion de dependencias
        private readonly IInfoUsersRepository _repository; 
        public userController(IInfoUsersRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public JsonResult GetUsers()
        {
            return new JsonResult(_repository.GetUsers());
        }//UsersData.UniqueInstance sería _UsersData con InyeccDep
        [HttpGet("/{id}")]
        public IActionResult GetUsers(int iduser) // Actionresult empaqueta muchas cosas, permite devolver 404 o el error que sea
        {
            var user = _repository.GetUser(iduser);
            if(user == null)
            {
                return NotFound(); // NOt found es un metodo de mvc que retorna 404
            }
            return Ok(user); // retorna 200
        }
    }
}
