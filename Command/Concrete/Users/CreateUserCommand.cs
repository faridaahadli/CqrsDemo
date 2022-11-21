using CqrsDemo.Command.Abstract;

namespace CqrsDemo.Command.Concrete.Users
{
    public class CreateUserCommand:ICommand<int>
    {
         public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
}
