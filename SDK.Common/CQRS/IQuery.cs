using MediatR;

namespace SDK.Common.CQRS;

public interface IQuery<out TResponse> : IRequest<TResponse>  
    where TResponse : notnull
{
}
