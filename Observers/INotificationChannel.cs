using NotificationSystem.Models;

namespace NotificationSystem.Observers
{
    public interface INotificationChannel
    {
        void Update(IUser user, string message);
    }
}