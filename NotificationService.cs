using NotificationSystem.Models;
using NotificationSystem.Observers;

namespace NotificationSystem
{
    public class NotificationService
    {
        private readonly List<INotificationChannel> _channels = new();

        public void Subscribe(INotificationChannel channel)
        {
            _channels.Add(channel);
        }

        public void Unsubscribe(INotificationChannel channel)
        {
            _channels.Remove(channel);
        }

        public void Notify(IUser user, string message)
        {
            foreach (var channel in _channels)
            {
                channel.Update(user, message);
            }
        }
    }
}