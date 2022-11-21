using CqrsDemo.Entities;
using CqrsDemo.Query.Abstract;

namespace CqrsDemo.Query.Concrete
{
    public class GetAllOrdersQuery:IQuery<ICollection<Order>>
    {
    }
}
