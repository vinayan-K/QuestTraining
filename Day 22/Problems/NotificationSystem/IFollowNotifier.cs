﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    internal interface IFollowNotifier
    {
        string Notify(string targetUserName, string userName);
    }
}
