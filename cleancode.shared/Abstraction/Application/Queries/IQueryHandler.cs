using MediatR;

namespace cleancode.shared.Abstraction.Application.Queries
{
    public interface IQueryHandler<TIn, TOut> : IRequestHandler<TIn, TOut>
        where TIn : IQuery<TOut>
    { }
}
