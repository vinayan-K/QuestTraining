using System;
using System.Threading;

namespace NotificationSystem
{
    class FollowNotification : IFollowNotifier
    {
        public string Notify(string targetUserName, string userName)
        {
            Thread.Sleep(1000);
            return $"{userName} started following you";
        }
    }
}
