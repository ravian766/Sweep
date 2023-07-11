using ServerSweep.Shared.Notifications;

namespace ClientSweep.Client.Infrastructure.Notifications;

public interface INotificationPublisher
{
    Task PublishAsync(INotificationMessage notification);
}