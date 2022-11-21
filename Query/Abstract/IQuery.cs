using MediatR;

namespace CqrsDemo.Query.Abstract
{
    public interface IQuery<out TResult>:IRequest<TResult>
    {
    }
}
