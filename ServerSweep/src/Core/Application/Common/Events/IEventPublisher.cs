using ServerSweep.Shared.Events;

namespace ServerSweep.Application.Common.Events;

public interface IEventPublisher : ITransientService
{
    Task PublishAsync(IEvent @event);
}