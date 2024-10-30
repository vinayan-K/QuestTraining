using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var notification = new NotificationManager();
            var commentNotification = new CommentNotification();
            var likeNotification = new LikeNotification();
            var followNotification = new FollowNotification();

            var cNotification = commentNotification.Notify("Alice", "Bob", "post123", "Great post!");
            var fNotification = followNotification.Notify("Alice", "Charlie");
            var lNotification = likeNotification.Notify("Alice", "Dave", "post123");

            notification.Add(cNotification);
            notification.Add(fNotification);
            notification.Add(lNotification);

            Console.WriteLine("Notifications:");
            notification.DisplayAll();

        }
    }
}
