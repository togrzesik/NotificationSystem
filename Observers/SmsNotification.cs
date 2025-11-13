using NotificationSystem.Models;

namespace NotificationSystem.Observers
{
    public class SmsNotification : INotificationChannel
    {
        public void Update(IUser user, string message)
        {
            Console.WriteLine($"📱 [SMS] To: {user.Phone} — {message}");
        }
    }
}
