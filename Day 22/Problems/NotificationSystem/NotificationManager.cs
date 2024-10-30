using System;
using System.Collections.Generic;
using System.Threading;

namespace NotificationSystem
{
    class NotificationManager
    {
        private readonly List<string> _notifications = new List<string>();

        public void Add(string notification)
        {
            _notifications.Add(notification);
        }

        public void DisplayAll()
        {
            foreach (var notification in _notifications)
            {
                Thread.Sleep(1000);
                Console.WriteLine(notification);
            }
        }
    }
}
