using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    internal interface ICommentNotifier
    {
        string Notify(string targetUserName, string userName, string postId, string comment);
    }
}
