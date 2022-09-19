using MediatR;

namespace cleancode.shared.Abstraction.Application.Commands
{
    public interface ICommandHandler<TIn, TOut> : IRequestHandler<TIn, Response<TOut>>
    where TIn : ICommand<TOut>
    { }
}
