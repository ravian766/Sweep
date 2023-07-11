using ServerSweep.Shared.Notifications;

namespace ClientSweep.Client.Infrastructure.Notifications;

public record ConnectionStateChanged(ConnectionState State, string? Message) : INotificationMessage;