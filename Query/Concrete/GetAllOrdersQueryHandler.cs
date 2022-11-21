using CqrsDemo.Database;
using CqrsDemo.Entities;
using CqrsDemo.Query.Abstract;
using Microsoft.EntityFrameworkCore;

namespace CqrsDemo.Query.Concrete
{
    public class GetAllOrdersQueryHandler: IQueryHandler<GetAllOrdersQuery, ICollection<Order>>
    {
        private readonly AppDbContext _context;

        public GetAllOrdersQueryHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Order>> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            return await _context.Orders.ToListAsync();
        }
    }
}
