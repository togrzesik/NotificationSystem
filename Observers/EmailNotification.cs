using NotificationSystem.Models;

namespace NotificationSystem.Observers
{
    public class EmailNotification : INotificationChannel
    {
        public void Update(IUser user, string message)
        {
            Console.WriteLine($"📧 [Email] To: {user.Email} — {message}");
        }
    }
}
