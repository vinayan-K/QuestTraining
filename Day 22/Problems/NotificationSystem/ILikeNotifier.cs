using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    internal interface ILikeNotifier
    {
        string Notify(string targetUsername, string userName, string postId);
    }
}
