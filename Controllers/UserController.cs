using CqrsDemo.Command.Concrete.Users;
using CqrsDemo.Query.Concrete;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CqrsDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediatR;
        public UserController(IMediator mediatR)
        {
            _mediatR = mediatR;     
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var user = await _mediatR.Send(new GetUserQuery { Id = id });
            return Ok(user);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<IActionResult> Post(CreateUserCommand command)
        {
            var userId = await _mediatR.Send(command);
            return Ok(userId);
        }

       
    }
}
