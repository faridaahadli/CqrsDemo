using MediatR;

namespace CqrsDemo.Command.Abstract
{
    public interface ICommand<out TResult>:IRequest<TResult>
    {

    }
}
