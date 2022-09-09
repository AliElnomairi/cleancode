using MediatR;

namespace cleancode.shared.Abstraction.Application.Commands
{
    public interface ICommand<T> : IRequest<Response<T>> { }
}
