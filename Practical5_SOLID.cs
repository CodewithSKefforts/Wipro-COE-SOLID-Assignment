// Practical 5: Notification Management
// Objective: Apply all 5 SOLID principles.
// Added WhatsApp notification without modifying existing NotificationManager class.

using System;
using System.Collections.Generic;

namespace SolidAssignments.Practical5
{
    // Abstraction (DIP)
    public interface INotificationChannel
    {
        void SendMessage(string msg);
    }

    // Notification Channel 1: Email
    public class EmailNotification : INotificationChannel
    {
        public void SendMessage(string msg)
        {
            Console.WriteLine("Sending Email: " + msg);
        }
    }

    // Notification Channel 2: SMS
    public class SmsNotification : INotificationChannel
    {
        public void SendMessage(string msg)
        {
            Console.WriteLine("Sending SMS: " + msg);
        }
    }

    // Notification Channel 3: Push Notification
    public class PushNotification : INotificationChannel
    {
        public void SendMessage(string msg)
        {
            Console.WriteLine("Sending Push Notification: " + msg);
        }
    }

    // New Channel added without breaking/changing existing channels (OCP)
    public class WhatsAppNotification : INotificationChannel
    {
        public void SendMessage(string msg)
        {
            Console.WriteLine("Sending WhatsApp Message: " + msg);
        }
    }

    // Manager Class
    public class NotificationManager
    {
        private readonly List<INotificationChannel> _channels;

        public NotificationManager(List<INotificationChannel> channels)
        {
            _channels = channels;
        }

        public void BroadcastMessage(string message)
        {
            foreach (var channel in _channels)
            {
                channel.SendMessage(message);
            }
        }
    }
}