using CqrsDemo.Database;
using CqrsDemo.Entities;
using CqrsDemo.Query.Abstract;

namespace CqrsDemo.Query.Concrete
{
    public class GetUserQueryHandler:IQueryHandler<GetUserQuery,User>
    {
        private readonly AppDbContext _context;

        public GetUserQueryHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<User> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            return await _context.Users.FindAsync(request.Id);
        }
    }
}
