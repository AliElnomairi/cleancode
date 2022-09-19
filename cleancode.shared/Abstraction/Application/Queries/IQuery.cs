using MediatR;

namespace cleancode.shared.Abstraction.Application.Queries
{
    public interface IQuery<TOut> : IRequest<TOut> { }
}
