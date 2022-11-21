using CqrsDemo.Entities;
using CqrsDemo.Query.Abstract;

namespace CqrsDemo.Query.Concrete
{
    public class GetUserQuery:IQuery<User>
    {
        public int Id { get; set; }
    }
}
