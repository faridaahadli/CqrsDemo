using CqrsDemo.Database;
using CqrsDemo.Entities;
using MediatR;

namespace CqrsDemo.Command.Concrete.Users
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly AppDbContext _context;

        public CreateUserCommandHandler(AppDbContext context)
        {
            _context = context;
        }
        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            User user = new User
            {
                Name = request.Name,
                Surname = request.Surname,
                Age= request.Age
            };
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync(cancellationToken);
            return user.Id;
        }
    }
}
