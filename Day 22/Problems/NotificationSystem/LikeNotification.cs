using System;
using System.Threading;

namespace NotificationSystem
{
    class LikeNotification : ILikeNotifier
    {
        public string Notify(string targetUsername, string userName, string postId)
        {
            Thread.Sleep(1000);
            return $"{userName} Liked your {postId}";
        }
    }
}
