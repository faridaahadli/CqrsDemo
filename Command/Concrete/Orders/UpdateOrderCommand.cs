using CqrsDemo.Command.Abstract;

namespace CqrsDemo.Command.Concrete.Orders
{
    public class UpdateOrderCommand:ICommand<int>
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int UserId { get; set; }
    }
}
