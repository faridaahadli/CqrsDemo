using CqrsDemo.Command.Abstract;
using CqrsDemo.Database;
using CqrsDemo.Entities;

namespace CqrsDemo.Command.Concrete.Orders
{
    public class CreateOrderCommandHandler : ICommandHandler<CreateOrderCommand, int>
    {
        private readonly AppDbContext _context;
        public CreateOrderCommandHandler(AppDbContext context)
        {
            _context = context;
        }
        public async Task<int> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            Order order = new Order
            {
                Price = request.Price,
                UserId = request.UserId
            };
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();

            return order.Id;
        }
    }
}
