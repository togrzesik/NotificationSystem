﻿using NotificationSystem;
using NotificationSystem.Models;
using NotificationSystem.Observers;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("🔔 Notification System Demo\n");

        // Create user
        var user = new User("Tomasz Grzesik", "tomasz@example.com", "+48123123123");

        // Create NotificationService
        var notificationService = new NotificationService();

        // Subscribe different channels of Notifictation
        notificationService.Subscribe(new EmailNotification());
        notificationService.Subscribe(new SmsNotification());
        notificationService.Subscribe(new PushNotification());

        // Send message
        notificationService.Notify(user, "Your order has been shipped! 📦");

        // We remove the SMS subscription and send another message
        Console.WriteLine("\n❌ Unsubscribing SMS notifications...\n");
        notificationService.Unsubscribe(new SmsNotification()); // ← it doesn't work here because of the new object (Correct version below)

        // Correct version
        var smsChannel = new SmsNotification();
        notificationService.Subscribe(smsChannel);
        notificationService.Notify(user, "Shipment status updated.");

        notificationService.Unsubscribe(smsChannel);
        notificationService.Notify(user, "Thank you for shopping!");
    }
}