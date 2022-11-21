using CqrsDemo.Command.Abstract;
using CqrsDemo.Database;

namespace CqrsDemo.Command.Concrete.Orders
{
    public class UpdateOrderCommandHandler : ICommandHandler<UpdateOrderCommand, int>
    {
        private readonly AppDbContext _context;
        public UpdateOrderCommandHandler(AppDbContext context)
        {
            _context = context;
        }
        public async Task<int> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
        {
            var order=await _context.Orders.FindAsync(request.Id);
            if (order == null)
                throw new Exception("order is not exist");
            order.UserId = request.UserId;
            order.Price = request.Price;

            await _context.SaveChangesAsync();
            return order.Id;
        }
    }
}
