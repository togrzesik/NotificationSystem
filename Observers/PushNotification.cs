using NotificationSystem.Models;

namespace NotificationSystem.Observers
{
    public class PushNotification : INotificationChannel
    {
        public void Update(IUser user, string message)
        {
            Console.WriteLine($"🔔 [Push] To: {user.Name} — {message}");
        }
    }
}