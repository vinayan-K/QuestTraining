using System;
using System.Threading;

namespace NotificationSystem
{
    class CommentNotification : ICommentNotifier
    {
        public string Notify(string targetUserName, string userName, string postId, string comment)
        {
            Thread.Sleep(1000);
            return $"{userName} commented '{comment}' on your {postId}";
        }
    }
}
