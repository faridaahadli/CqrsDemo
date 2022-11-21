namespace CqrsDemo.Query.Abstract
{
    public interface IQueryHandler<in TQuery,TResult> where TQuery : IQuery<TResult>
    {
    }
}
