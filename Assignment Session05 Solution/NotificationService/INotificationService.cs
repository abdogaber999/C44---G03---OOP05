using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Session05_Solution.NotificationService
{
    internal interface INotificationService
    {
        void SendNotification(string recipient, string message);
    }
}
