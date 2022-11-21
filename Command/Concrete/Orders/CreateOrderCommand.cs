using CqrsDemo.Command.Abstract;

namespace CqrsDemo.Command.Concrete.Orders
{
    public class CreateOrderCommand:ICommand<int>
    {
        public decimal Price { get; set; }
        public int UserId { get; set; }
    }
}
