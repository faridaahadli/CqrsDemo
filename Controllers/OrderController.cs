using CqrsDemo.Command.Concrete.Orders;
using CqrsDemo.Query.Concrete;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CqrsDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediatR;
        public OrderController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var orders = await _mediatR.Send(new GetAllOrdersQuery());
            return Ok(orders);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateOrderCommand command)
        {
            var orderId=await _mediatR.Send(command);
            return Ok(orderId); 
        }

        
        [HttpPut]
        public async Task<IActionResult> Put(UpdateOrderCommand command)
        {
            var orderId = await _mediatR.Send(command);
            return Ok(orderId);
        }

        
    }
}
